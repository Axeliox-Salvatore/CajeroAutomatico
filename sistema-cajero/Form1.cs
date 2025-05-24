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
//using MySql.Data.MySqlClient;


namespace sistema_cajero
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btniniciarsesion_Click(object sender, EventArgs e)
        {
            // Validar que los campos no estén vacíos
            if (string.IsNullOrWhiteSpace(txtusuario.Text) || string.IsNullOrWhiteSpace(txtcontraseña.Text))
            {
                MessageBox.Show("Por favor, ingresa tu correo, nombre o DUI y tu PIN.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Obtener usuario y PIN ingresados
            string usuario = txtusuario.Text.Trim();
            string pin = txtcontraseña.Text.Trim();

            // Conexión con MySQL
            MySqlConnection conexion = ConexionDB.Conexion();

            try
            {
                conexion.Open();

                // Consulta SQL: Buscar en `Clientes` y `UsuariosBanco`
                string consulta = @"
            SELECT 'Cliente' AS Tipo FROM Clientes WHERE (Correo = @usuario OR Nombre = @usuario OR DUI = @usuario) AND PIN = SHA2(@pin, 256)
            UNION
            SELECT 'Banco' AS Tipo FROM UsuariosBanco WHERE (Correo = @usuario OR Nombre = @usuario OR DUI = @usuario) AND PIN = SHA2(@pin, 256)";

                MySqlCommand comando = new MySqlCommand(consulta, conexion);
                comando.Parameters.AddWithValue("@usuario", usuario);
                comando.Parameters.AddWithValue("@pin", pin);

                object resultado = comando.ExecuteScalar();

                if (resultado != null)
                {
                    MessageBox.Show("¡Bienvenido!", "Acceso concedido", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Determinar si el usuario es Cliente o Banco
                    string tipoUsuario = resultado.ToString();

                    conexion.Close(); // Cierra conexión después de verificar

                    this.Hide();
                    if (tipoUsuario == "Banco")
                        new PanelBanco().Show(); // Redirigir al Panel Banco
                    else
                        new Menu().Show(); // Redirigir al Panel Cliente
                }
                else
                {
                    conexion.Close(); // Cerrar si el login es incorrecto
                    MessageBox.Show("Correo, nombre o DUI incorrecto, o PIN incorrecto.", "Error de acceso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de conexión: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void SeleccionRegistro_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Volver a mostrar el formulario de Login cuando se cierre SeleccionRegistro
            Form1 login = new Form1();
            login.Show();
        }
        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            SeleccionRegistro Seleccion = new SeleccionRegistro();
            Seleccion.Show();
            this.Hide();
          
          
    }

        private void btnMantenimiento_Click(object sender, EventArgs e)
        {
            Mantenimiento ventanaMantenimiento = new Mantenimiento();
            ventanaMantenimiento.Show();
            this.Hide();
        }
    }
}
