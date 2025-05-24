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

        private void btnretiro_Click(object sender, EventArgs e)
        {
            Retiro ventanaRetiro = new Retiro();
            ventanaRetiro.Show();
            this.Hide();
        }

        private void btndeposito_Click(object sender, EventArgs e)
        {
            Depositos ventanaDeposito = new Depositos();
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
            Transferencia ventanaTransferencia = new Transferencia();
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

        /*private void button1_Click(object sender, EventArgs e)//botoin para probar si hay conexion, despues se elimina
        {
            string consulta = "SELECT * FROM cuentasexternas";
            MySqlConnection Miconexion = ConexionDB.Conexion();

            try
            {
                //abrimos la conexion a la base de datos
                Miconexion.Open();
                //creamos el comando
                MySqlCommand comando = new MySqlCommand(consulta, Miconexion);
                MySqlDataAdapter adapter = new MySqlDataAdapter(comando);

                DataTable dt = new DataTable();
                adapter.Fill(dt);
                Miconexion.Close();
                dgbPrue.DataSource = dt;
            }
            catch(MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }*/
    }
}
