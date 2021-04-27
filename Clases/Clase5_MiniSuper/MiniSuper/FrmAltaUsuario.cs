using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniSuper
{
    public partial class FrmAltaUsuario : Form
    {
        private Usuario usuario;

        public FrmAltaUsuario()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.usuario = new Usuario(this.txtNombre.Text,this.txtApellido.Text,(long)this.numDni.Value); //como no es texto me lo retorna en Value

            this.Close();
        }
    }
}
