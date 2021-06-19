using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Entidades;

namespace FrmPrincipal
{
    public partial class frmPrincipal : Form
    {
        Jardin garden;
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            this.garden = new Jardin(100);
            bool pudo = this.garden + new Arbusto("Arbusto 1", 10);
            pudo = this.garden + new Arbusto("Arbusto 2", 15);
            pudo = this.garden + new Rosal("Rosa 1", 20, Rosal.Color.Amarilla);
            pudo = this.garden + new Rosal("Rosa clásica", 25);
            pudo = this.garden + new Banano("Banano ecuador", 30, "ECU001");
            if (!(this.garden + new Banano("No carga", 1, "ARG028")))
            {
                Console.WriteLine("ERROR!");
            }

        }

        private void btnVerDatos_Click(object sender, EventArgs e)
        {
            rtbSalidaDeTest.Text = garden.ToString();

            //MessageBox.Show(garden.ToString());
        }
    }
}
