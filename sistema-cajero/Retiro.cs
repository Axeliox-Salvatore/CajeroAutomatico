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
    public partial class Retiro: Form
    {
        public Retiro()
        {
            InitializeComponent();
        }

        private void btnretirar_Click(object sender, EventArgs e)
        {
            string dui = mtxtdui.Text.Trim();
            decimal montoRetiro;

            if (!decimal.TryParse(txtcantidad.Text.Trim(), out montoRetiro) || montoRetiro <= 0)
            {
                MessageBox.Show("Ingrese un monto válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (MySqlConnection conexion = ConexionDB.Conexion())
            {
                conexion.Open();

                // Verificar saldo actual
                string consultaSaldo = "SELECT Saldo FROM Clientes WHERE DUI = @dui";
                MySqlCommand cmdSaldo = new MySqlCommand(consultaSaldo, conexion);
                cmdSaldo.Parameters.AddWithValue("@dui", dui);

                object resultado = cmdSaldo.ExecuteScalar();
                if (resultado == null)
                {
                    MessageBox.Show("Usuario no encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                decimal saldoActual = Convert.ToDecimal(resultado);

                if (montoRetiro > saldoActual)
                {
                    MessageBox.Show("Saldo insuficiente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Realizar el retiro
                string actualizarSaldo = "UPDATE Clientes SET Saldo = Saldo - @monto WHERE DUI = @dui";
                MySqlCommand cmdActualizar = new MySqlCommand(actualizarSaldo, conexion);
                cmdActualizar.Parameters.AddWithValue("@monto", montoRetiro);
                cmdActualizar.Parameters.AddWithValue("@dui", dui);

                cmdActualizar.ExecuteNonQuery();

                MessageBox.Show("Retiro realizado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conexion.Close();

                Menu menu = new Menu();
                menu.Show();
                this.Close();
            }
        }

        private void txtcantidad_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtcantidad_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
