
namespace tema5_ejercicio_3
{
    partial class reproductor
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.playPause = new System.Windows.Forms.Button();
            this.lblMinutos = new System.Windows.Forms.Label();
            this.lblSegundos = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // playPause
            // 
            this.playPause.Location = new System.Drawing.Point(3, 26);
            this.playPause.Name = "playPause";
            this.playPause.Size = new System.Drawing.Size(75, 23);
            this.playPause.TabIndex = 0;
            this.playPause.UseVisualStyleBackColor = true;
            this.playPause.Click += new System.EventHandler(this.playPause_Click);
            // 
            // lblMinutos
            // 
            this.lblMinutos.AutoSize = true;
            this.lblMinutos.Location = new System.Drawing.Point(19, 10);
            this.lblMinutos.Name = "lblMinutos";
            this.lblMinutos.Size = new System.Drawing.Size(19, 13);
            this.lblMinutos.TabIndex = 1;
            this.lblMinutos.Text = "00";
            // 
            // lblSegundos
            // 
            this.lblSegundos.AutoSize = true;
            this.lblSegundos.Location = new System.Drawing.Point(35, 10);
            this.lblSegundos.Name = "lblSegundos";
            this.lblSegundos.Size = new System.Drawing.Size(19, 13);
            this.lblSegundos.TabIndex = 2;
            this.lblSegundos.Text = "00";
            // 
            // reproductor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblSegundos);
            this.Controls.Add(this.lblMinutos);
            this.Controls.Add(this.playPause);
            this.Name = "reproductor";
            this.Size = new System.Drawing.Size(86, 64);
            this.Load += new System.EventHandler(this.reproductor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button playPause;
        private System.Windows.Forms.Label lblMinutos;
        private System.Windows.Forms.Label lblSegundos;
    }
}
