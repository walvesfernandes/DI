
namespace ejercicio3DI
{
    partial class Ejer3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ejer3));
            this.salir = new System.Windows.Forms.Button();
            this.color1 = new System.Windows.Forms.TextBox();
            this.color2 = new System.Windows.Forms.TextBox();
            this.color3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.imgRutaTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCambiar = new System.Windows.Forms.Button();
            this.msjError = new System.Windows.Forms.Label();
            this.imgBox = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imgBox)).BeginInit();
            this.SuspendLayout();
            // 
            // salir
            // 
            this.salir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.salir.Location = new System.Drawing.Point(655, 483);
            this.salir.Name = "salir";
            this.salir.Size = new System.Drawing.Size(75, 23);
            this.salir.TabIndex = 5;
            this.salir.Text = "salir";
            this.salir.UseVisualStyleBackColor = true;
            this.salir.Click += new System.EventHandler(this.btnSalir);
            this.salir.MouseEnter += new System.EventHandler(this.btnCambiar_MouseEnter);
            this.salir.MouseLeave += new System.EventHandler(this.btnCambiar_MouseEnter);
            this.salir.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mouseTitle);
            // 
            // color1
            // 
            this.color1.Location = new System.Drawing.Point(38, 90);
            this.color1.Name = "color1";
            this.color1.Size = new System.Drawing.Size(100, 20);
            this.color1.TabIndex = 0;
            this.color1.TabStop = false;
            this.color1.Tag = "";
            this.color1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mouseTitle);
            // 
            // color2
            // 
            this.color2.Location = new System.Drawing.Point(144, 89);
            this.color2.Name = "color2";
            this.color2.Size = new System.Drawing.Size(100, 20);
            this.color2.TabIndex = 1;
            this.color2.TabStop = false;
            this.color2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mouseTitle);
            // 
            // color3
            // 
            this.color3.Location = new System.Drawing.Point(250, 89);
            this.color3.Name = "color3";
            this.color3.Size = new System.Drawing.Size(100, 20);
            this.color3.TabIndex = 2;
            this.color3.TabStop = false;
            this.color3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mouseTitle);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Color en RGB:";
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mouseTitle);
            // 
            // imgRutaTxt
            // 
            this.imgRutaTxt.Location = new System.Drawing.Point(503, 89);
            this.imgRutaTxt.Name = "imgRutaTxt";
            this.imgRutaTxt.Size = new System.Drawing.Size(100, 20);
            this.imgRutaTxt.TabIndex = 4;
            this.imgRutaTxt.TabStop = false;
            this.imgRutaTxt.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mouseTitle);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "R";
            this.label2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mouseTitle);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(141, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "G";
            this.label3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mouseTitle);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(247, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "B";
            this.label4.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mouseTitle);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(500, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Ruta imagen";
            this.label5.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mouseTitle);
            // 
            // btnCambiar
            // 
            this.btnCambiar.Location = new System.Drawing.Point(366, 90);
            this.btnCambiar.Name = "btnCambiar";
            this.btnCambiar.Size = new System.Drawing.Size(105, 23);
            this.btnCambiar.TabIndex = 3;
            this.btnCambiar.Text = "color";
            this.btnCambiar.UseVisualStyleBackColor = true;
            this.btnCambiar.Click += new System.EventHandler(this.btnCambiar_Click);
            this.btnCambiar.MouseEnter += new System.EventHandler(this.btnCambiar_MouseEnter);
            this.btnCambiar.MouseLeave += new System.EventHandler(this.btnCambiar_MouseEnter);
            this.btnCambiar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mouseTitle);
            // 
            // msjError
            // 
            this.msjError.AutoSize = true;
            this.msjError.Location = new System.Drawing.Point(38, 13);
            this.msjError.Name = "msjError";
            this.msjError.Size = new System.Drawing.Size(0, 13);
            this.msjError.TabIndex = 11;
            // 
            // imgBox
            // 
            this.imgBox.Location = new System.Drawing.Point(41, 166);
            this.imgBox.Name = "imgBox";
            this.imgBox.Size = new System.Drawing.Size(309, 169);
            this.imgBox.TabIndex = 12;
            this.imgBox.TabStop = false;
            this.imgBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mouseTitle);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(503, 128);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "ver img";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.verImg);
            this.button1.MouseEnter += new System.EventHandler(this.btnCambiar_MouseEnter);
            this.button1.MouseLeave += new System.EventHandler(this.btnCambiar_MouseEnter);
            this.button1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mouseTitle);
            // 
            // Ejer3
            // 
            this.AcceptButton = this.btnCambiar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.salir;
            this.ClientSize = new System.Drawing.Size(794, 538);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.imgBox);
            this.Controls.Add(this.msjError);
            this.Controls.Add(this.btnCambiar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.imgRutaTxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.color3);
            this.Controls.Add(this.color2);
            this.Controls.Add(this.color1);
            this.Controls.Add(this.salir);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Ejer3";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Colores e Imágenes";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Ejer3TeclaT);
            this.MouseEnter += new System.EventHandler(this.btnCambiar_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.Ejer3_MouseLeave_1);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mouseTitle);
            ((System.ComponentModel.ISupportInitialize)(this.imgBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button salir;
        private System.Windows.Forms.TextBox color1;
        private System.Windows.Forms.TextBox color2;
        private System.Windows.Forms.TextBox color3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox imgRutaTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCambiar;
        private System.Windows.Forms.Label msjError;
        private System.Windows.Forms.PictureBox imgBox;
        private System.Windows.Forms.Button button1;
    }
}

