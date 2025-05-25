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
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();    

        }
        //Nueva variable para almacenar el ID del usuario logueado
        public static int UsuarioIDActual;

        //Se mantiene la variable que almacena el correo, nombre o DUI ingresado
        public static string UsuarioIngresado;


        private void btniniciarsesion_Click(object sender, EventArgs e)
        {
            // Validacion para evitar campos vacíos
            if (string.IsNullOrWhiteSpace(txtusuario.Text) || string.IsNullOrWhiteSpace(txtcontraseña.Text))
            {
                MessageBox.Show("Por favor, ingresa tu correo, nombre o DUI y tu PIN.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string usuario = txtusuario.Text.Trim();
            string pin = txtcontraseña.Text.Trim();
            MySqlConnection conexion = ConexionDB.Conexion();

            try
            {
                conexion.Open();

                //aqui obtenemos el ID del usuario y su tipo (Cliente/Banco)
                string consulta = @"
                    SELECT ID, 'Cliente' AS Tipo FROM Clientes 
                    WHERE (Correo = @usuario OR Nombre = @usuario OR DUI = @usuario) AND PIN = SHA2(@pin, 256)
                    UNION
                    SELECT ID, 'Banco' AS Tipo FROM UsuariosBanco 
                    WHERE (Correo = @usuario OR Nombre = @usuario OR DUI = @usuario) AND PIN = SHA2(@pin, 256)";

                MySqlCommand comando = new MySqlCommand(consulta, conexion);
                comando.Parameters.AddWithValue("@usuario", usuario);
                comando.Parameters.AddWithValue("@pin", pin);

                // Ahora: Usamos ExecuteReader() para obtener varios valores (ID y Tipo de usuario)
                MySqlDataReader lector = comando.ExecuteReader();
                if (lector.Read()) // Si hay datos
                {
                    //Guardamos el ID del usuario
                    UsuarioIDActual = lector.GetInt32(0);
                    UsuarioIngresado = usuario; // Guardamos el usuario ingresado
                    string tipoUsuario = lector.GetString(1); // Obtenemos el tipo (Cliente o Banco)

                    MessageBox.Show($"Bienvenido, ID: {UsuarioIDActual}", "Acceso concedido", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    conexion.Close();
                    this.Hide();

                    //aqui menu puede obtener el ID usando UsuarioIDActual
                    if (tipoUsuario == "Banco")
                        new PanelBanco().Show();
                    else
                        new Menu().Show();
                }
                else
                {
                    conexion.Close();
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
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
