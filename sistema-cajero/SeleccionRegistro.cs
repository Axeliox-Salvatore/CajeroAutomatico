using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistema_cajero
{
    public partial class SeleccionRegistro: Form
    {
        public SeleccionRegistro()
        {
            InitializeComponent();
            this.FormClosing += SeleccionRegistro_FormClosing; // Suscripción al evento de cierre

        }

        private void SeleccionRegistro_Load(object sender, EventArgs e)
        {

        }
        private void SeleccionRegistro_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Si el usuario no eligió una opción y solo cerró el formulario,
            // volvemos a mostrar Login
            Form1 login = new Form1();
            login.Show();
        }

        private void btnReBanco_Click(object sender, EventArgs e)
        {
            RegistroBanco Banco = new RegistroBanco();
            Banco.Show();
            this.Hide();
        }

        private void btnReCliente_Click(object sender, EventArgs e)
        {
            RegistroCliente cliente = new RegistroCliente();
            cliente.Show();
            this.Hide();
        }
    }
}
