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
    public partial class Servicios: Form
    {
        public Servicios()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            string tipoServicio = cmbTipoServicio.SelectedItem.ToString();
            string numeroPago = txtNumeroPago.Text.Trim();
            decimal montoPago;

            if (string.IsNullOrWhiteSpace(numeroPago))
            {
                MessageBox.Show("Ingrese el número de pago de la factura.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(txtMonto.Text.Trim(), out montoPago) || montoPago <= 0)
            {
                MessageBox.Show("Ingrese un monto válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (MySqlConnection conexion = ConexionDB.Conexion())
            {
                conexion.Open();

                // Verificar si el pago existe y su estado
                string verificarPago = "SELECT Monto, Estado FROM Pagos WHERE NumeroPago = @numeroPago AND Tipo = @tipoServicio";
                MySqlCommand cmdVerificarPago = new MySqlCommand(verificarPago, conexion);
                cmdVerificarPago.Parameters.AddWithValue("@numeroPago", numeroPago);
                cmdVerificarPago.Parameters.AddWithValue("@tipoServicio", tipoServicio);

                decimal montoRestante = 0;
                string estadoPago = "";

                using (MySqlDataReader reader = cmdVerificarPago.ExecuteReader())
                {
                    if (!reader.Read())
                    {
                        MessageBox.Show("Numero de pago no encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    montoRestante = reader.GetDecimal(0);
                    estadoPago = reader.GetString(1);
                    reader.Close();
                }

                if (estadoPago == "Pagado" || montoRestante == 0)
                {
                    MessageBox.Show("Esta factura ya ha sido pagada en su totalidad.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (montoPago > montoRestante)
                {
                    MessageBox.Show($"El monto ingresado supera el saldo pendiente de ${montoRestante}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Validar saldo del cliente antes de pagar
                string consultaSaldo = "SELECT Saldo FROM Clientes WHERE ID = @clienteID";
                MySqlCommand cmdSaldo = new MySqlCommand(consultaSaldo, conexion);
                cmdSaldo.Parameters.AddWithValue("@clienteID", Form1.UsuarioIDActual);

                decimal saldoActual = Convert.ToDecimal(cmdSaldo.ExecuteScalar());
                if (montoPago > saldoActual)
                {
                    MessageBox.Show("Saldo insuficiente para pagar el servicio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Descontar el pago del saldo del cliente
                string actualizarSaldo = "UPDATE Clientes SET Saldo = Saldo - @monto WHERE ID = @clienteID";
                MySqlCommand cmdActualizarSaldo = new MySqlCommand(actualizarSaldo, conexion);
                cmdActualizarSaldo.Parameters.AddWithValue("@monto", montoPago);
                cmdActualizarSaldo.Parameters.AddWithValue("@clienteID", Form1.UsuarioIDActual);
                cmdActualizarSaldo.ExecuteNonQuery();

                //  Reducir el monto en Pagos
                string actualizarMonto = "UPDATE Pagos SET Monto = Monto - @monto WHERE NumeroPago = @numeroPago AND Tipo = @tipoServicio";
                MySqlCommand cmdActualizarMonto = new MySqlCommand(actualizarMonto, conexion);
                cmdActualizarMonto.Parameters.AddWithValue("@numeroPago", numeroPago);
                cmdActualizarMonto.Parameters.AddWithValue("@tipoServicio", tipoServicio);
                cmdActualizarMonto.Parameters.AddWithValue("@monto", montoPago);
                cmdActualizarMonto.ExecuteNonQuery();

                // Obtener saldo pendiente actualizado
                string verificarNuevoMonto = "SELECT Monto FROM Pagos WHERE NumeroPago = @numeroPago AND Tipo = @tipoServicio";
                MySqlCommand cmdNuevoMonto = new MySqlCommand(verificarNuevoMonto, conexion);
                cmdNuevoMonto.Parameters.AddWithValue("@numeroPago", numeroPago);
                cmdNuevoMonto.Parameters.AddWithValue("@tipoServicio", tipoServicio);
                decimal nuevoMonto = Convert.ToDecimal(cmdNuevoMonto.ExecuteScalar());

                // Si el monto restante es 0 cambiar estado a Pagado
                if (nuevoMonto == 0)
                {
                    string actualizarEstado = "UPDATE Pagos SET Estado = 'Pagado' WHERE NumeroPago = @numeroPago AND Tipo = @tipoServicio";
                    MySqlCommand cmdActualizarEstado = new MySqlCommand(actualizarEstado, conexion);
                    cmdActualizarEstado.Parameters.AddWithValue("@numeroPago", numeroPago);
                    cmdActualizarEstado.Parameters.AddWithValue("@tipoServicio", tipoServicio);
                    cmdActualizarEstado.ExecuteNonQuery();

                    MessageBox.Show($"Pago de ${montoPago} completado. **La factura esta completamente pagada.**", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"Pago de ${montoPago} procesado con exito. **Saldo pendiente: ${nuevoMonto}.**", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                conexion.Close();
                Application.Exit();
            }


        }
    }

}

