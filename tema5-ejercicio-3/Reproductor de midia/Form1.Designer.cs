
namespace Reproductor_de_midia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnDirectorio = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.reproductor1 = new tema5_ejercicio_3.reproductor();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDirectorio
            // 
            this.btnDirectorio.Location = new System.Drawing.Point(27, 203);
            this.btnDirectorio.Name = "btnDirectorio";
            this.btnDirectorio.Size = new System.Drawing.Size(75, 23);
            this.btnDirectorio.TabIndex = 1;
            this.btnDirectorio.Text = "Open folder";
            this.btnDirectorio.UseVisualStyleBackColor = true;
            this.btnDirectorio.Click += new System.EventHandler(this.btnDirectorio_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(27, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(96, 113);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // reproductor1
            // 
            this.reproductor1.Location = new System.Drawing.Point(27, 131);
            this.reproductor1.Minutos = 0;
            this.reproductor1.Name = "reproductor1";
            this.reproductor1.Segundos = 0;
            this.reproductor1.Size = new System.Drawing.Size(83, 66);
            this.reproductor1.TabIndex = 0;
            this.reproductor1.DesbordarTiempo += new System.EventHandler(this.reproductor1_DesbordarTiempo);
            this.reproductor1.PulsacionBoton += new System.EventHandler(this.reproductor1_PulsacionBoton);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 244);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnDirectorio);
            this.Controls.Add(this.reproductor1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Simulador player";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private tema5_ejercicio_3.reproductor reproductor1;
        private System.Windows.Forms.Button btnDirectorio;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

