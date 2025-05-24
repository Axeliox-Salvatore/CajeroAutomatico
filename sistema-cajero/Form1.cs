using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
            Menu ventanaMenu = new Menu();
            ventanaMenu.Show();
            this.Hide(); 
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
