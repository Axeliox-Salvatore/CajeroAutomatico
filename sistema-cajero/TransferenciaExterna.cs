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
    public partial class TransferenciaExterna: Form
    {
        public TransferenciaExterna()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {
        }
            

        private void btnPagar_Click(object sender, EventArgs e)
        {
            string bancoDestino = txtBancoDestino.Text.Trim();//declarar variables para almacenar los datos de la transferencia
            string cuentaDestino = txtCuentaDestino.Text.Trim();
            decimal montoTransferencia;

            if (string.IsNullOrWhiteSpace(bancoDestino) || string.IsNullOrWhiteSpace(cuentaDestino))
            {
                MessageBox.Show("Ingrese el banco y la cuenta destino.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

                //  Validar saldo del remitente
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

                //  Restar al remitente
                string actualizarSaldoRemitente = "UPDATE Clientes SET Saldo = Saldo - @monto WHERE ID = @clienteID";
                MySqlCommand cmdRemitente = new MySqlCommand(actualizarSaldoRemitente, conexion);
                cmdRemitente.Parameters.AddWithValue("@monto", montoTransferencia);
                cmdRemitente.Parameters.AddWithValue("@clienteID", Form1.UsuarioIDActual);
                cmdRemitente.ExecuteNonQuery();

                //Registrar la transferencia en CuentasExternas
                string consultaRegistro = "INSERT INTO CuentasExternas (Banco, Cuenta, Valor) VALUES (@banco, @cuenta, @monto)";
                MySqlCommand cmdRegistro = new MySqlCommand(consultaRegistro, conexion);
                cmdRegistro.Parameters.AddWithValue("@banco", bancoDestino);
                cmdRegistro.Parameters.AddWithValue("@cuenta", cuentaDestino);
                cmdRegistro.Parameters.AddWithValue("@monto", montoTransferencia);
                cmdRegistro.ExecuteNonQuery();

                MessageBox.Show($"Transferencia de ₡{montoTransferencia} al banco {bancoDestino}, cuenta {cuentaDestino} realizada con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conexion.Close();



                Application.Exit(); //Cierra completamente la aplicación
            }
        }
    }
  
   
}
