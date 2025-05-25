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
    public partial class Mantenimiento: Form
    {
        public Mantenimiento()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsuario.Text))
            {
                MessageBox.Show("Por favor, ingresa tu correo o DUI.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string usuario = txtUsuario.Text.Trim();
            MySqlConnection conexion = ConexionDB.Conexion();

            try
            {
                conexion.Open();

                // Verificar si el usuario existe en Clientes o UsuariosBanco
                string consulta = @"
            SELECT 'Cliente' AS Tipo FROM Clientes WHERE Correo = @usuario OR DUI = @usuario
            UNION
            SELECT 'Banco' AS Tipo FROM UsuariosBanco WHERE Correo = @usuario OR DUI = @usuario";

                MySqlCommand comando = new MySqlCommand(consulta, conexion);
                comando.Parameters.AddWithValue("@usuario", usuario);

                object resultado = comando.ExecuteScalar();

                conexion.Close();

                if (resultado != null)
                {
                    MessageBox.Show("Cuenta encontrada. Ahora puedes cambiar tu PIN.", "Verificación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNuevoPIN.Enabled = true;
                    btnConfirmar.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Cuenta no encontrada. Revisa los datos ingresados.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de conexión: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsuario.Text) || string.IsNullOrWhiteSpace(txtNuevoPIN.Text))
            {
                MessageBox.Show("Por favor, ingresa tu usuario y nuevo PIN.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Obtener datos
            string usuario = txtUsuario.Text.Trim();
            string nuevoPIN = txtNuevoPIN.Text.Trim();

            // Validar que el PIN tenga al menos 4 dígitos
            if (nuevoPIN.Length < 4)
            {
                MessageBox.Show("El PIN debe tener al menos 4 dígitos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Conectar con MySQL
            MySqlConnection conexion = ConexionDB.Conexion();

            try
            {
                conexion.Open();

                // Actualizar el PIN encriptado en la tabla correspondiente
                string consulta = @"
            UPDATE Clientes SET PIN = SHA2(@nuevoPIN, 256) WHERE Correo = @usuario OR Nombre = @usuario OR DUI = @usuario;
            UPDATE UsuariosBanco SET PIN = SHA2(@nuevoPIN, 256) WHERE Correo = @usuario OR Nombre = @usuario OR DUI = @usuario;";

                MySqlCommand comando = new MySqlCommand(consulta, conexion);
                comando.Parameters.AddWithValue("@nuevoPIN", nuevoPIN);
                comando.Parameters.AddWithValue("@usuario", usuario);

                int filasAfectadas = comando.ExecuteNonQuery();

                conexion.Close();

                if (filasAfectadas > 0)
                {
                    MessageBox.Show("PIN actualizado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    new Form1().Show(); // Redirigir al login
                }
                else
                {
                    MessageBox.Show("No se encontró la cuenta asociada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de conexión: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
