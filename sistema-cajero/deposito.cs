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
    public partial class deposito: Form
    {
        public deposito()
        {
            InitializeComponent();
        }

        private void btndepositar_Click(object sender, EventArgs e)
        {

        }

       // private void btnPagar_Click(object sender, EventArgs e)
       // {
           
       // }

        private void btnPagar_Click_1(object sender, EventArgs e)
        {
            string dui = mtxtdui.Text.Trim();
            decimal montoDeposito;

            if (!decimal.TryParse(txtcantidad.Text.Trim(), out montoDeposito) || montoDeposito <= 0)
            {
                MessageBox.Show("Ingrese un monto válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (MySqlConnection conexion = ConexionDB.Conexion())
            {
                conexion.Open();

                // Verificar si el usuario existe
                string consultaSaldo = "SELECT Saldo FROM Clientes WHERE DUI = @dui";
                MySqlCommand cmdSaldo = new MySqlCommand(consultaSaldo, conexion);
                cmdSaldo.Parameters.AddWithValue("@dui", dui);

                object resultado = cmdSaldo.ExecuteScalar();
                if (resultado == null)
                {
                    MessageBox.Show("Usuario no encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Realizar el depósito
                string actualizarSaldo = "UPDATE Clientes SET Saldo = Saldo + @monto WHERE DUI = @dui";
                MySqlCommand cmdActualizar = new MySqlCommand(actualizarSaldo, conexion);
                cmdActualizar.Parameters.AddWithValue("@monto", montoDeposito);
                cmdActualizar.Parameters.AddWithValue("@dui", dui);

                cmdActualizar.ExecuteNonQuery();

                MessageBox.Show("Depósito realizado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conexion.Close();
            }
        }
    }
}
