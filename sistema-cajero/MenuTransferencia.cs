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
    public partial class MenuTransferencia: Form
    {
        public MenuTransferencia()
        {
            InitializeComponent();
        }

        private void btnTransExterna_Click(object sender, EventArgs e)
        {
            TransferenciaExterna Seleccion = new TransferenciaExterna();
            Seleccion.Show();
            this.Hide();

        }

        private void btnTransInterna_Click(object sender, EventArgs e)
        {
            Transferencia Seleccion = new Transferencia();
            Seleccion.Show();
            this.Hide();
        }
    }
}
