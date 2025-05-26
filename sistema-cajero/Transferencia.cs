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
    public partial class Transferencia: Form
    {
        public Transferencia()
        {
            InitializeComponent();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
           
            

        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            string duiDestino = mtxtdui.Text.Trim();
            decimal montoTransferencia;

            if (string.IsNullOrWhiteSpace(duiDestino))
            {
                MessageBox.Show("Ingrese el DUI del destinatario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(txtMonto.Text.Trim(), out montoTransferencia) || montoTransferencia <= 0)
            {
                MessageBox.Show("Ingrese un monto válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (MySqlConnection conexion = ConexionDB.Conexion())
            {
                conexion.Open();

                //Verificar si la cuenta destino existe con DUI
                string consultaDestino = "SELECT ID FROM Clientes WHERE DUI = @duiDestino";
                MySqlCommand cmdDestino = new MySqlCommand(consultaDestino, conexion);
                cmdDestino.Parameters.AddWithValue("@duiDestino", duiDestino);

                object resultadoDestino = cmdDestino.ExecuteScalar();
                if (resultadoDestino == null)
                {
                    MessageBox.Show("Cuenta destino no encontrada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                //Validar saldo del remitente
                string consultaSaldo = "SELECT Saldo FROM Clientes WHERE ID = @clienteID";
                MySqlCommand cmdSaldo = new MySqlCommand(consultaSaldo, conexion);
                cmdSaldo.Parameters.AddWithValue("@clienteID", Form1.UsuarioIDActual);

                object resultadoSaldo = cmdSaldo.ExecuteScalar();
                if (resultadoSaldo == null)
                {
                    MessageBox.Show("Error al obtener el saldo del remitente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                decimal saldoActual = Convert.ToDecimal(resultadoSaldo);
                if (montoTransferencia > saldoActual)
                {
                    MessageBox.Show("Saldo insuficiente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                //Realizar la transferenci Restar al remitente
                string actualizarSaldoRemitente = "UPDATE Clientes SET Saldo = Saldo - @monto WHERE ID = @clienteID";
                MySqlCommand cmdRemitente = new MySqlCommand(actualizarSaldoRemitente, conexion);
                cmdRemitente.Parameters.AddWithValue("@monto", montoTransferencia);
                cmdRemitente.Parameters.AddWithValue("@clienteID", Form1.UsuarioIDActual);
                cmdRemitente.ExecuteNonQuery();

                //Realizar la transferencia: Sumar al destinatario con DUI
                string actualizarSaldoDestino = "UPDATE Clientes SET Saldo = Saldo + @monto WHERE DUI = @duiDestino";
                MySqlCommand cmdDestinoUpdate = new MySqlCommand(actualizarSaldoDestino, conexion);
                cmdDestinoUpdate.Parameters.AddWithValue("@monto", montoTransferencia);
                cmdDestinoUpdate.Parameters.AddWithValue("@duiDestino", duiDestino);
                cmdDestinoUpdate.ExecuteNonQuery();

                MessageBox.Show($"Transferencia de ₡{montoTransferencia} a la cuenta con DUI {duiDestino} realizada con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conexion.Close();

                Menu menu = new Menu();
                menu.Show();
                this.Close();


            
      
            }
        }

        private void txtMonto_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtMonto_TextChanged(object sender, EventArgs e)
        {

        }
    }

}
