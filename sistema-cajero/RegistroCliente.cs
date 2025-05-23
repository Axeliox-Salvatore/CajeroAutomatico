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
    public partial class RegistroCliente: Form
    {
        public RegistroCliente()
        {
            InitializeComponent();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void RegistroCliente_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            
        
            // Inicializar variables con los valores ingresados en los TextBox
            string nombre = txtNombre.Text.Trim();
            string apellido = txtApellido.Text.Trim();
            string dui = mtbDui.Text.Replace("-", "").Trim();
            string correo = txtCorreo.Text.Trim();
            string telefono = mtbTelefono.Text.Replace("-", "").Trim();
            string tipoCuenta = cmbTipoCuenta.SelectedItem.ToString();
            string pin = mtbPin.Text.Trim();
            decimal saldoInicial;

            // Validar saldo como numero
            if (!decimal.TryParse(txtSaldo.Text.Trim(), out saldoInicial))
            {
                MessageBox.Show("El saldo inicial debe ser un valor numerico.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validaciones de campos vacios y longitud
            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(apellido) || string.IsNullOrWhiteSpace(dui) ||
                string.IsNullOrWhiteSpace(correo) || string.IsNullOrWhiteSpace(telefono) || string.IsNullOrWhiteSpace(tipoCuenta) ||
                string.IsNullOrWhiteSpace(pin) || dui.Length != 9 || telefono.Length != 8 || pin.Length != 4)
            {
                MessageBox.Show("Revisa los datos ingresados. DUI debe tener 9 digitos, telefono 8 y PIN 4.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Conectar con MySQL
            MySqlConnection conexion = ConexionDB.Conexion();
            try
            {
                conexion.Open();//abrimos la conexoin para que se pueda hacer la consulta

                // Verificar si el DUI o Correo ya estan registrados
                string verificarQuery = "SELECT COUNT(*) FROM Clientes WHERE DUI = @dui OR Correo = @correo";
                MySqlCommand verificarCmd = new MySqlCommand(verificarQuery, conexion);// aqui se hace la consulta
                verificarCmd.Parameters.AddWithValue("@dui", dui);// aqui se le asigna el valor a la consulta
                verificarCmd.Parameters.AddWithValue("@correo", correo);//

                // aqui se ejecuta la consulta y se guarda el resultado en la variable existe
                int existe = Convert.ToInt32(verificarCmd.ExecuteScalar());
                if (existe > 0)
                {
                    MessageBox.Show("El DUI o el correo ya estan registrados.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    conexion.Close();
                    return;
                }

                // Insertar nuevo cliente
                string insertarQuery = "INSERT INTO Clientes (Nombre, Apellido, DUI, Correo, Telefono, TipoCuenta, PIN, Saldo) " +
                                       "VALUES (@nombre, @apellido, @dui, @correo, @telefono, @tipoCuenta, SHA2(@pin, 256), @saldo)";
                MySqlCommand insertarCmd = new MySqlCommand(insertarQuery, conexion);

                insertarCmd.Parameters.AddWithValue("@nombre", nombre);
                insertarCmd.Parameters.AddWithValue("@apellido", apellido);
                insertarCmd.Parameters.AddWithValue("@dui", dui);
                insertarCmd.Parameters.AddWithValue("@correo", correo);
                insertarCmd.Parameters.AddWithValue("@telefono", telefono);
                insertarCmd.Parameters.AddWithValue("@tipoCuenta", tipoCuenta);
                insertarCmd.Parameters.AddWithValue("@pin", pin);
                insertarCmd.Parameters.AddWithValue("@saldo", saldoInicial);

                insertarCmd.ExecuteNonQuery();
                conexion.Close();

                MessageBox.Show("Cliente registrado correctamente.", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Cerrar FormRegistroCliente y SeleccionRegistro, luego redirigir a Login
                this.Hide();
                foreach (Form form in Application.OpenForms)
                {
                    if (form is SeleccionRegistro)
                    {
                        form.Close();
                        break;
                    }
                }
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

