using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace sistema_cajero
{
    public partial class Pago: Form
    {
        public Pago()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          

        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            decimal montoPago;

            if (!decimal.TryParse(txtMontoPago.Text.Trim(), out montoPago) || montoPago <= 0)
            {
                MessageBox.Show("Ingrese un monto valido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (MySqlConnection conexion = ConexionDB.Conexion())
            {
                conexion.Open();

                // 🔹 Verificar si el cliente tiene préstamo activo
                string consultaPrestamo = "SELECT SaldoPendiente, Estado FROM Prestamos WHERE ClienteID = @clienteID";
                MySqlCommand cmdPrestamo = new MySqlCommand(consultaPrestamo, conexion);
                cmdPrestamo.Parameters.AddWithValue("@clienteID", Form1.UsuarioIDActual);

                decimal saldoPendiente = 0;
                string estadoPrestamo = "";

                using (MySqlDataReader reader = cmdPrestamo.ExecuteReader())
                {
                    if (!reader.Read())
                    {
                        MessageBox.Show("No tiene prestamo registrado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    saldoPendiente = reader.GetDecimal(0);
                    estadoPrestamo = reader.GetString(1);
                    reader.Close();
                }

                if (estadoPrestamo == "Pagado" || saldoPendiente == 0)
                {
                    MessageBox.Show("Este prestamo ya esta pagado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (montoPago > saldoPendiente)
                {
                    MessageBox.Show($"El monto ingresado excede el saldo pendiente de ${saldoPendiente}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Descontar el monto del saldo pendiente
                string actualizarSaldo = "UPDATE Prestamos SET SaldoPendiente = SaldoPendiente - @monto WHERE ClienteID = @clienteID";
                MySqlCommand cmdActualizarSaldo = new MySqlCommand(actualizarSaldo, conexion);
                cmdActualizarSaldo.Parameters.AddWithValue("@monto", montoPago);
                cmdActualizarSaldo.Parameters.AddWithValue("@clienteID", Form1.UsuarioIDActual);
                cmdActualizarSaldo.ExecuteNonQuery();

                // Obtener nuevo saldo pendiente
                string verificarSaldo = "SELECT SaldoPendiente FROM Prestamos WHERE ClienteID = @clienteID";
                MySqlCommand cmdVerificarSaldo = new MySqlCommand(verificarSaldo, conexion);
                cmdVerificarSaldo.Parameters.AddWithValue("@clienteID", Form1.UsuarioIDActual);
                decimal saldoFinal = Convert.ToDecimal(cmdVerificarSaldo.ExecuteScalar());

                // Si el saldo pendiente llega a 0, actualizar estado a Pagado
                if (saldoFinal == 0)
                {
                    string actualizarEstado = "UPDATE Prestamos SET Estado = 'Pagado' WHERE ClienteID = @clienteID";
                    MySqlCommand cmdActualizarEstado = new MySqlCommand(actualizarEstado, conexion);
                    cmdActualizarEstado.Parameters.AddWithValue("@clienteID", Form1.UsuarioIDActual);
                    cmdActualizarEstado.ExecuteNonQuery();

                    MessageBox.Show($"Pago de ₡{montoPago} procesado con exito. **El prestamo ha sido completamente pagado.**", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"Pago de ${montoPago} procesado con exito. **Saldo pendiente: ${saldoFinal}.**", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                conexion.Close();
                Application.Exit();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conexion = ConexionDB.Conexion())
            {
                conexion.Open();

                // 🔹 Obtener el saldo pendiente del préstamo
                string consultaPrestamo = "SELECT SaldoPendiente, Estado FROM Prestamos WHERE ClienteID = @clienteID";
                MySqlCommand cmdPrestamo = new MySqlCommand(consultaPrestamo, conexion);
                cmdPrestamo.Parameters.AddWithValue("@clienteID", Form1.UsuarioIDActual);

                using (MySqlDataReader reader = cmdPrestamo.ExecuteReader())
                {
                    if (!reader.Read())
                    {
                        MessageBox.Show("No tiene prestamo registrado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    decimal saldoPendiente = reader.GetDecimal(0);
                    string estadoPrestamo = reader.GetString(1);
                    reader.Close();

                    if (estadoPrestamo == "Pagado" || saldoPendiente == 0)
                    {
                        MessageBox.Show("Este prestamo ya esta pagado en su totalidad.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show($"Saldo pendiente del prestamo: **${saldoPendiente}.**", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

                conexion.Close();
            }

        }

        private void txtMontoPago_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo números, un punto y teclas de control (como backspace)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
                MessageBox.Show("Por favor, ingrese solo números o un punto decimal.", "Entrada no válida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            // Solo permitir un punto decimal
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
