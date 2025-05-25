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
using Mysqlx.Connection;

namespace sistema_cajero
{
    public partial class Menu : Form
    {
        
        public Menu()
        {
            InitializeComponent();
  
        }


        //BOTNES
        private void btnretiro_Click(object sender, EventArgs e)
        {
            Retiro ventanaRetiro = new Retiro();
            ventanaRetiro.Show();
            this.Hide();
        }

        private void btndeposito_Click(object sender, EventArgs e)
        {
            Deposito ventanaDeposito = new Deposito();
            ventanaDeposito.Show();
            this.Hide();
        }

        private void btnretiroremesa_Click(object sender, EventArgs e)
        {
            Retiroremesa ventanaRetiroRemesa = new Retiroremesa();
            ventanaRetiroRemesa.Show();
            this.Hide();
        }

        private void btngenerarremesa_Click(object sender, EventArgs e)
        {
            Generarremesa ventanaGenerarRemesa = new Generarremesa();
            ventanaGenerarRemesa.Show();
            this.Hide();
        }

        private void btnmantenimiento_Click(object sender, EventArgs e)
        {
            
        }

        private void btntransferencia_Click(object sender, EventArgs e)
        {
            MenuTransferencia ventanaTransferencia = new    MenuTransferencia();
            ventanaTransferencia.Show();
            this.Hide();
        }

        private void btnservicios_Click(object sender, EventArgs e)
        {
            Servicios ventanaServicios = new Servicios();
            ventanaServicios.Show();
            this.Hide();
        }

        private void btnpagos_Click(object sender, EventArgs e)
        {
            Pago ventanaPago = new Pago();
            ventanaPago.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        //METODOS y FUNCIONES

        //aqui es mejor crear los metodos para el saldo 
        
        
        // Método para obtener el saldo del usuario con el ID obtenido
        private void MostrarSaldo(int usuarioID)
        {
            MySqlConnection conexion = ConexionDB.Conexion();

            try
            {
                conexion.Open();
                string consulta = "SELECT Saldo FROM Clientes WHERE ID = @usuarioID";

                MySqlCommand comando = new MySqlCommand(consulta, conexion);
                comando.Parameters.AddWithValue("@usuarioID", usuarioID);

                object resultado = comando.ExecuteScalar();
                conexion.Close();

                lblSaldo.Text = resultado != null ? $"$ {resultado.ToString()}" : "Saldo no disponible";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener el saldo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        //Aqui se carga el menu y se muestran los datos del usuario deberia ir arriba pero asi que quede
        private void Menu_Load(object sender, EventArgs e)
        {
            // Mostramos el usuario en sesion antes de cargar los datos
            MessageBox.Show($"Usuario en sesión: {Form1.UsuarioIngresado}", "Depuración", MessageBoxButtons.OK, MessageBoxIcon.Information);
            // Pasamos el ID directamente desde Form1
            MostrarSaldo(Form1.UsuarioIDActual);

        }

        private void btnMantenimineto_Click(object sender, EventArgs e)
        {
           
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Cierra la aplicación
        }
    }
}

