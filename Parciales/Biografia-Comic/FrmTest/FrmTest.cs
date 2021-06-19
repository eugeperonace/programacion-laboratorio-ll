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

namespace FrmTest
{
    public partial class FrmTest : Form
    {
        private Vendedor vendedor;

        public FrmTest()
        {
            InitializeComponent();
            vendedor = new Vendedor("Santiago Gomez");
        }

        /// <summary>
        /// Harcodea las publicaciones y las agrega a la ListBox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmTest_Load(object sender, EventArgs e)
        {
            Biografia p1 = (Biografia)"Life (Keith Richards)";
            Biografia p2 = new Biografia("White line fever (Lemmy)", 5);
            Biografia p3 = new Biografia("Commando (Johnny Ramone)", 2, 5000);
            Comic p4 = new Comic("La Muerte de Superman (Superman)", true, 1, 1850);
            Comic p5 = new Comic("Año Uno (Batman)", false, 3, 1270);

            lstStock.Items.Add(p1);
            lstStock.Items.Add(p2);
            lstStock.Items.Add(p3);
            lstStock.Items.Add(p4);
            lstStock.Items.Add(p5);
        }

        /// <summary>
        /// Cierra el formulario preguntandole antes al usuario si realemente quiere salir.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Vende las publicaciones seleccionadas en la ListBox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnVender_Click(object sender, EventArgs e)
        {
            if (!(lstStock.SelectedItem is null))
            {
                Publicacion venta = (Publicacion)lstStock.SelectedItem;

                if (venta.HayStock && vendedor + venta)
                {
                    MessageBox.Show("Se realizó la venta.", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No hay stock.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Seleccione la publicación que quiera vender.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Muestra en el RichTextBox los datos de las ventas del vendedor.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnVerInforme_Click(object sender, EventArgs e)
        {
            rtbInforme.Text = Vendedor.InformeDeVentas(vendedor);
        }

        /// <summary>
        /// Cierra el formulario preguntandole antes al usuario si realemente quiere salir.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmTest_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult respuesta;

            respuesta = MessageBox.Show("¿Está seguro que desea salir?","STOP", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (respuesta == DialogResult.Yes)
            {
                this.Dispose();
            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}
