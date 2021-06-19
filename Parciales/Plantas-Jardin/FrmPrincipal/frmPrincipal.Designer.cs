namespace FrmPrincipal
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.rtbSalidaDeTest = new System.Windows.Forms.RichTextBox();
            this.btnVerDatos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtbSalidaDeTest
            // 
            this.rtbSalidaDeTest.Location = new System.Drawing.Point(30, 76);
            this.rtbSalidaDeTest.Name = "rtbSalidaDeTest";
            this.rtbSalidaDeTest.Size = new System.Drawing.Size(554, 224);
            this.rtbSalidaDeTest.TabIndex = 0;
            this.rtbSalidaDeTest.Text = "";
            // 
            // btnVerDatos
            // 
            this.btnVerDatos.Location = new System.Drawing.Point(469, 26);
            this.btnVerDatos.Name = "btnVerDatos";
            this.btnVerDatos.Size = new System.Drawing.Size(75, 23);
            this.btnVerDatos.TabIndex = 1;
            this.btnVerDatos.Text = "Ver Datos";
            this.btnVerDatos.UseVisualStyleBackColor = true;
            this.btnVerDatos.Click += new System.EventHandler(this.btnVerDatos_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGreen;
            this.ClientSize = new System.Drawing.Size(610, 337);
            this.Controls.Add(this.btnVerDatos);
            this.Controls.Add(this.rtbSalidaDeTest);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jardin";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbSalidaDeTest;
        private System.Windows.Forms.Button btnVerDatos;
    }
}

