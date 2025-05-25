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
                MessageBox.Show("Ingrese un monto válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (MySqlConnection conexion = ConexionDB.Conexion())
            {
                conexion.Open();

                // 🔹 Verificar si el cliente tiene préstamo activo
                string consultaPrestamo = "SELECT SaldoPendiente, Estado FROM Prestamos WHERE ClienteID = @clienteID";
                MySqlCommand cmdPrestamo = new MySqlCommand(consultaPrestamo, conexion);
                cmdPrestamo.Parameters.AddWithValue("@clienteID", Form1.UsuarioIDActual);

                using (MySqlDataReader reader = cmdPrestamo.ExecuteReader())
                {
                    if (!reader.Read())
                    {
                        MessageBox.Show("No tiene préstamo registrado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    decimal saldoPendiente = reader.GetDecimal(0);// 
                    string estadoPrestamo = reader.GetString(1);
                    reader.Close();

                    if (estadoPrestamo == "Pagado" || saldoPendiente == 0)
                    {
                        MessageBox.Show("Este préstamo ya está pagado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    if (montoPago > saldoPendiente)
                    {
                        MessageBox.Show("El monto ingresado excede el saldo pendiente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Descontar el monto del saldo pendiente
                    string actualizarSaldo = "UPDATE Prestamos SET SaldoPendiente = SaldoPendiente - @monto WHERE ClienteID = @clienteID";
                    MySqlCommand cmdActualizarSaldo = new MySqlCommand(actualizarSaldo, conexion);
                    cmdActualizarSaldo.Parameters.AddWithValue("@monto", montoPago);
                    cmdActualizarSaldo.Parameters.AddWithValue("@clienteID", Form1.UsuarioIDActual);
                    cmdActualizarSaldo.ExecuteNonQuery();

                    // Si el saldo pendiente llega a 0, actualizar estado a Pagado
                    string verificarSaldo = "SELECT SaldoPendiente FROM Prestamos WHERE ClienteID = @clienteID";
                    MySqlCommand cmdVerificarSaldo = new MySqlCommand(verificarSaldo, conexion);
                    cmdVerificarSaldo.Parameters.AddWithValue("@clienteID", Form1.UsuarioIDActual);
                    decimal saldoFinal = Convert.ToDecimal(cmdVerificarSaldo.ExecuteScalar());

                    if (saldoFinal == 0)
                    {
                        string actualizarEstado = "UPDATE Prestamos SET Estado = 'Pagado' WHERE ClienteID = @clienteID";
                        MySqlCommand cmdActualizarEstado = new MySqlCommand(actualizarEstado, conexion);
                        cmdActualizarEstado.Parameters.AddWithValue("@clienteID", Form1.UsuarioIDActual);
                        cmdActualizarEstado.ExecuteNonQuery();
                    }

                    MessageBox.Show($"Pago de ₡{montoPago} procesado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                conexion.Close();



                Application.Exit(); // 
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
