﻿using System;
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
    public partial class Retiroremesa: Form
    {
        public Retiroremesa()
        {
            InitializeComponent();
        }

        private void btnretirarremesa_Click(object sender, EventArgs e)
        {
            string dui = mtxtdui.Text.Trim();
            decimal montoRemesa;

            if (!decimal.TryParse(txtcantidad.Text.Trim(), out montoRemesa) || montoRemesa <= 0)
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

                // Sumar la remesa al saldo
                string actualizarSaldo = "UPDATE Clientes SET Saldo = Saldo + @monto WHERE DUI = @dui";
                MySqlCommand cmdActualizar = new MySqlCommand(actualizarSaldo, conexion);
                cmdActualizar.Parameters.AddWithValue("@monto", montoRemesa);
                cmdActualizar.Parameters.AddWithValue("@dui", dui);

                cmdActualizar.ExecuteNonQuery();

                MessageBox.Show("Remesa retirada y saldo actualizado.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conexion.Close();

                Menu menu = new Menu();
                menu.Show();
                this.Close();
            }
        }

        private void mtxtcodremesa_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

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
    }
}
