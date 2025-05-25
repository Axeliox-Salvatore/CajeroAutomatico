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
            string cuentaDestino = txtCuentaDestino.Text.Trim();
            decimal montoTransferencia;

            if (string.IsNullOrWhiteSpace(cuentaDestino))
            {
                MessageBox.Show("Ingrese el número de cuenta destino.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

                // 🔹 Verificar si la cuenta destino ya existe en `CuentasExternas`
                string verificarCuenta = "SELECT Valor FROM CuentasExternas WHERE Cuenta = @cuenta";
                MySqlCommand cmdVerificar = new MySqlCommand(verificarCuenta, conexion);
                cmdVerificar.Parameters.AddWithValue("@cuenta", cuentaDestino);
                object saldoDestino = cmdVerificar.ExecuteScalar();

                if (saldoDestino == null)
                {
                    MessageBox.Show("La cuenta destino no existe en los registros.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // 🔹 Validar saldo del remitente antes de transferir
                string consultaSaldo = "SELECT Saldo FROM Clientes WHERE ID = @clienteID";
                MySqlCommand cmdSaldo = new MySqlCommand(consultaSaldo, conexion);
                cmdSaldo.Parameters.AddWithValue("@clienteID", Form1.UsuarioIDActual);
                object saldoRemitente = cmdSaldo.ExecuteScalar();

                if (saldoRemitente == null)
                {
                    MessageBox.Show("Error al obtener el saldo del remitente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                decimal saldoActual = Convert.ToDecimal(saldoRemitente);
                if (montoTransferencia > saldoActual)
                {
                    MessageBox.Show("Saldo insuficiente para la transferencia.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Descontar el saldo del remitente
                string actualizarSaldoRemitente = "UPDATE Clientes SET Saldo = Saldo - @monto WHERE ID = @clienteID";
                MySqlCommand cmdActualizarRemitente = new MySqlCommand(actualizarSaldoRemitente, conexion);
                cmdActualizarRemitente.Parameters.AddWithValue("@monto", montoTransferencia);
                cmdActualizarRemitente.Parameters.AddWithValue("@clienteID", Form1.UsuarioIDActual);
                cmdActualizarRemitente.ExecuteNonQuery();

                // ✅ Actualizar saldo de la cuenta destino
                string actualizarSaldoDestino = "UPDATE CuentasExternas SET Valor = Valor + @monto WHERE Cuenta = @cuenta";
                MySqlCommand cmdActualizarDestino = new MySqlCommand(actualizarSaldoDestino, conexion);
                cmdActualizarDestino.Parameters.AddWithValue("@monto", montoTransferencia);
                cmdActualizarDestino.Parameters.AddWithValue("@cuenta", cuentaDestino);
                cmdActualizarDestino.ExecuteNonQuery();

                MessageBox.Show($"Transferencia de ${montoTransferencia} a la cuenta {cuentaDestino} completada.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conexion.Close();

                Application.Exit(); //Cierra la aplicación tras la transferencia
            }

        }
    }
  
   
}
