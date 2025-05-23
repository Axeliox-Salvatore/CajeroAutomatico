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
    public partial class RegistroBanco: Form
    {
        public RegistroBanco()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            //validamos las variables
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string dui = mtbDui.Text.Replace("-","").Trim();//Reemplazamos el guion 
            string correo = txtCorreo.Text;
            string telefono = mtbTelefono.Text.Replace("-","").Trim();//
            string pin = mtbPin.Text.Trim();

            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(apellido) ||
                string.IsNullOrWhiteSpace(dui) || string.IsNullOrWhiteSpace(correo) ||
                string.IsNullOrWhiteSpace(telefono) || string.IsNullOrWhiteSpace(pin))
            {
             MessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (dui.Length != 9)
            {
                MessageBox.Show("El DUI debe tener 9 Digitos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (telefono.Length != 8) // Teléfono debe tener 8 dígitos
            {
                MessageBox.Show("El teléfono debe tener 8 dígitos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Conectar con MySQL
            MySqlConnection conexion = ConexionDB.Conexion();
            try
            {
                conexion.Open();

                // Verificar si el DUI o el Correo ya están registrados
                string verificarQuery = "SELECT COUNT(*) FROM UsuariosBanco WHERE DUI = @dui OR Correo = @correo";
                MySqlCommand verificarCmd = new MySqlCommand(verificarQuery, conexion);
                verificarCmd.Parameters.AddWithValue("@dui", dui);
                verificarCmd.Parameters.AddWithValue("@correo", correo);

                int existe = Convert.ToInt32(verificarCmd.ExecuteScalar());
                if (existe > 0)
                {
                    MessageBox.Show("El DUI o el Correo ya están registrados.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    conexion.Close();
                    return;
                }

                // Si no está registrado, proceder con la inserción
                string insertarQuery = "INSERT INTO UsuariosBanco (Nombre, Apellido, DUI, Correo, Telefono, PIN) " +
                                       "VALUES (@nombre, @apellido, @dui, @correo, @telefono, SHA2(@pin, 256))";
                MySqlCommand insertarCmd = new MySqlCommand(insertarQuery, conexion);

                insertarCmd.Parameters.AddWithValue("@nombre", nombre);
                insertarCmd.Parameters.AddWithValue("@apellido", apellido);
                insertarCmd.Parameters.AddWithValue("@dui", dui);
                insertarCmd.Parameters.AddWithValue("@correo", correo);
                insertarCmd.Parameters.AddWithValue("@telefono", telefono);
                insertarCmd.Parameters.AddWithValue("@pin", pin);

                insertarCmd.ExecuteNonQuery();
                conexion.Close();

                MessageBox.Show("Usuario Banco registrado correctamente.", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                Form1 login = new Form1();
                login.Show();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en el registro: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
