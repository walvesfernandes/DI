
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
            this.textboxLabel1 = new DI5.TextboxLabel();
            this.SuspendLayout();
            // 
            // textboxLabel1
            // 
            this.textboxLabel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.textboxLabel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.textboxLabel1.Location = new System.Drawing.Point(29, 35);
            this.textboxLabel1.Name = "textboxLabel1";
            this.textboxLabel1.Posicion = DI5.TextboxLabel.ePosicion.IZQUIERDA;
            this.textboxLabel1.PswChr = '\0';
            this.textboxLabel1.Separacion = 0;
            this.textboxLabel1.Size = new System.Drawing.Size(185, 20);
            this.textboxLabel1.TabIndex = 0;
            this.textboxLabel1.TextLbl = "TextboxLabel";
            this.textboxLabel1.TextTxt = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textboxLabel1);
            this.Name = "Form1";
            this.Text = "Principal";
            this.ResumeLayout(false);

        }

        #endregion

        private DI5.TextboxLabel textboxLabel1;
    }
}

