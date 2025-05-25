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

                // Verificar si la factura ya esta pagada
                string verificarMonto = "SELECT Monto FROM ServiciosPagados WHERE NumeroPago = @numeroPago AND Tipo = @tipoServicio";
                MySqlCommand cmdVerificarMonto = new MySqlCommand(verificarMonto, conexion);
                cmdVerificarMonto.Parameters.AddWithValue("@numeroPago", numeroPago);
                cmdVerificarMonto.Parameters.AddWithValue("@tipoServicio", tipoServicio);

                object montoRestante = cmdVerificarMonto.ExecuteScalar();
                if (montoRestante != null && Convert.ToDecimal(montoRestante) == 0)
                {
                    MessageBox.Show("Esta factura ya ha sido pagada en su totalidad.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return; // Evita que se descuente saldo innecesariamente
                }

                //  Validar saldo del cliente antes de pagar
                string consultaSaldo = "SELECT Saldo FROM Clientes WHERE ID = @clienteID";
                MySqlCommand cmdSaldo = new MySqlCommand(consultaSaldo, conexion);
                cmdSaldo.Parameters.AddWithValue("@clienteID", Form1.UsuarioIDActual);

                object resultadoSaldo = cmdSaldo.ExecuteScalar();
                if (resultadoSaldo == null)
                {
                    MessageBox.Show("Error al obtener el saldo del cliente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                decimal saldoActual = Convert.ToDecimal(resultadoSaldo);
                if (montoPago > saldoActual)
                {
                    MessageBox.Show("Saldo insuficiente para pagar el servicio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                //  Descontar el pago del saldo del cliente
                string actualizarSaldo = "UPDATE Clientes SET Saldo = Saldo - @monto WHERE ID = @clienteID";
                MySqlCommand cmdActualizarSaldo = new MySqlCommand(actualizarSaldo, conexion);
                cmdActualizarSaldo.Parameters.AddWithValue("@monto", montoPago);
                cmdActualizarSaldo.Parameters.AddWithValue("@clienteID", Form1.UsuarioIDActual);
                cmdActualizarSaldo.ExecuteNonQuery();

                // Reducir el monto en ServiciosPagados
                string actualizarMonto = "UPDATE ServiciosPagados SET Monto = Monto - @monto WHERE NumeroPago = @numeroPago AND Tipo = @tipoServicio";
                MySqlCommand cmdActualizarMonto = new MySqlCommand(actualizarMonto, conexion);
                cmdActualizarMonto.Parameters.AddWithValue("@numeroPago", numeroPago);
                cmdActualizarMonto.Parameters.AddWithValue("@tipoServicio", tipoServicio);
                cmdActualizarMonto.Parameters.AddWithValue("@monto", montoPago);
                cmdActualizarMonto.ExecuteNonQuery();

                // Verificar si el monto restante es 0 para actualizar Estado
                montoRestante = cmdVerificarMonto.ExecuteScalar();
                if (montoRestante != null && Convert.ToDecimal(montoRestante) == 0)
                {
                    string actualizarEstado = "UPDATE ServiciosPagados SET Estado = 'Pagado' WHERE NumeroPago = @numeroPago AND Tipo = @tipoServicio";
                    MySqlCommand cmdActualizarEstado = new MySqlCommand(actualizarEstado, conexion);
                    cmdActualizarEstado.Parameters.AddWithValue("@numeroPago", numeroPago);
                    cmdActualizarEstado.Parameters.AddWithValue("@tipoServicio", tipoServicio);
                    cmdActualizarEstado.ExecuteNonQuery();
                }

                MessageBox.Show($"Pago de ${montoPago} por {tipoServicio} procesado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conexion.Close();

            }

            Application.Exit();
        }
    }
    }

