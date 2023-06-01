
namespace Principal
{
    partial class Form1
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
            this.lblClick = new System.Windows.Forms.Label();
            this.lblContador = new System.Windows.Forms.Label();
            this.etiquetaAviso2 = new EtiquetaAviso.EtiquetaAviso();
            this.etiquetaAviso1 = new EtiquetaAviso.EtiquetaAviso();
            this.SuspendLayout();
            // 
            // lblClick
            // 
            this.lblClick.AutoSize = true;
            this.lblClick.Location = new System.Drawing.Point(95, 35);
            this.lblClick.Name = "lblClick";
            this.lblClick.Size = new System.Drawing.Size(91, 13);
            this.lblClick.TabIndex = 2;
            this.lblClick.Text = "Click en la marca:";
            // 
            // lblContador
            // 
            this.lblContador.AutoSize = true;
            this.lblContador.Location = new System.Drawing.Point(182, 35);
            this.lblContador.Name = "lblContador";
            this.lblContador.Size = new System.Drawing.Size(13, 13);
            this.lblContador.TabIndex = 3;
            this.lblContador.Text = "0";
            // 
            // etiquetaAviso2
            // 
            this.etiquetaAviso2.ColorFinal = System.Drawing.Color.White;
            this.etiquetaAviso2.ColorInicial = System.Drawing.Color.White;
            this.etiquetaAviso2.Gradiente = false;
            this.etiquetaAviso2.ImgEtiqueta = null;
            this.etiquetaAviso2.Location = new System.Drawing.Point(98, 66);
            this.etiquetaAviso2.Marca = EtiquetaAviso.eMarca.Circulo;
            this.etiquetaAviso2.Name = "etiquetaAviso2";
            this.etiquetaAviso2.Size = new System.Drawing.Size(131, 53);
            this.etiquetaAviso2.TabIndex = 4;
            this.etiquetaAviso2.Text = "etiquetaAviso2";
            this.etiquetaAviso2.ClickEnMarca += new System.EventHandler(this.etiquetaAviso2_ClickEnMarca);
            // 
            // etiquetaAviso1
            // 
            this.etiquetaAviso1.ColorFinal = System.Drawing.Color.Maroon;
            this.etiquetaAviso1.ColorInicial = System.Drawing.Color.White;
            this.etiquetaAviso1.Gradiente = true;
            this.etiquetaAviso1.Location = new System.Drawing.Point(76, -95);
            this.etiquetaAviso1.Marca = EtiquetaAviso.eMarca.Imagen;
            this.etiquetaAviso1.Name = "etiquetaAviso1";
            this.etiquetaAviso1.Size = new System.Drawing.Size(523, 0);
            this.etiquetaAviso1.TabIndex = 0;
            this.etiquetaAviso1.Text = "etiquetaAviso1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.etiquetaAviso2);
            this.Controls.Add(this.lblContador);
            this.Controls.Add(this.lblClick);
            this.Controls.Add(this.etiquetaAviso1);
            this.Name = "Form1";
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private EtiquetaAviso.EtiquetaAviso etiquetaAviso1;
        private System.Windows.Forms.Label lblClick;
        private System.Windows.Forms.Label lblContador;
        private EtiquetaAviso.EtiquetaAviso etiquetaAviso2;
    }
}

