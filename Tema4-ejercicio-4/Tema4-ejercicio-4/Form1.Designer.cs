namespace Tema4_ejercicio_4
{
    partial class Calculadora
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
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.rBtnSuma = new System.Windows.Forms.RadioButton();
            this.rBtnResta = new System.Windows.Forms.RadioButton();
            this.rBtnDivision = new System.Windows.Forms.RadioButton();
            this.rBtnMultiplicacion = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.operador = new System.Windows.Forms.Label();
            this.msj = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(103, 45);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(72, 20);
            this.textBox2.TabIndex = 1;
            this.textBox2.TextChanged += new System.EventHandler(this.cambiaColorTxtBox);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 154);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // rBtnSuma
            // 
            this.rBtnSuma.AutoSize = true;
            this.rBtnSuma.Location = new System.Drawing.Point(12, 70);
            this.rBtnSuma.Name = "rBtnSuma";
            this.rBtnSuma.Size = new System.Drawing.Size(50, 17);
            this.rBtnSuma.TabIndex = 2;
            this.rBtnSuma.TabStop = true;
            this.rBtnSuma.Tag = "+";
            this.rBtnSuma.Text = "suma";
            this.rBtnSuma.UseVisualStyleBackColor = true;
            this.rBtnSuma.Click += new System.EventHandler(this.CambiarOperador);
            // 
            // rBtnResta
            // 
            this.rBtnResta.AutoSize = true;
            this.rBtnResta.Location = new System.Drawing.Point(12, 93);
            this.rBtnResta.Name = "rBtnResta";
            this.rBtnResta.Size = new System.Drawing.Size(48, 17);
            this.rBtnResta.TabIndex = 3;
            this.rBtnResta.TabStop = true;
            this.rBtnResta.Tag = "-";
            this.rBtnResta.Text = "resta";
            this.rBtnResta.UseVisualStyleBackColor = true;
            this.rBtnResta.Click += new System.EventHandler(this.CambiarOperador);
            // 
            // rBtnDivision
            // 
            this.rBtnDivision.AutoSize = true;
            this.rBtnDivision.Location = new System.Drawing.Point(103, 70);
            this.rBtnDivision.Name = "rBtnDivision";
            this.rBtnDivision.Size = new System.Drawing.Size(60, 17);
            this.rBtnDivision.TabIndex = 4;
            this.rBtnDivision.TabStop = true;
            this.rBtnDivision.Tag = "/";
            this.rBtnDivision.Text = "division";
            this.rBtnDivision.UseVisualStyleBackColor = true;
            this.rBtnDivision.Click += new System.EventHandler(this.CambiarOperador);
            // 
            // rBtnMultiplicacion
            // 
            this.rBtnMultiplicacion.AutoSize = true;
            this.rBtnMultiplicacion.Location = new System.Drawing.Point(103, 93);
            this.rBtnMultiplicacion.Name = "rBtnMultiplicacion";
            this.rBtnMultiplicacion.Size = new System.Drawing.Size(88, 17);
            this.rBtnMultiplicacion.TabIndex = 5;
            this.rBtnMultiplicacion.TabStop = true;
            this.rBtnMultiplicacion.Tag = "*";
            this.rBtnMultiplicacion.Text = "multiplicacion";
            this.rBtnMultiplicacion.UseVisualStyleBackColor = true;
            this.rBtnMultiplicacion.Click += new System.EventHandler(this.CambiarOperador);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(3, 44);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(72, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.cambiaColorTxtBox);
            // 
            // operador
            // 
            this.operador.AutoSize = true;
            this.operador.Location = new System.Drawing.Point(90, 45);
            this.operador.Name = "operador";
            this.operador.Size = new System.Drawing.Size(0, 13);
            this.operador.TabIndex = 8;
            // 
            // msj
            // 
            this.msj.AutoSize = true;
            this.msj.Location = new System.Drawing.Point(9, 18);
            this.msj.Name = "msj";
            this.msj.Size = new System.Drawing.Size(0, 13);
            this.msj.TabIndex = 9;
            // 
            // Calculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(197, 204);
            this.Controls.Add(this.msj);
            this.Controls.Add(this.operador);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.rBtnMultiplicacion);
            this.Controls.Add(this.rBtnDivision);
            this.Controls.Add(this.rBtnResta);
            this.Controls.Add(this.rBtnSuma);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Name = "Calculadora";
            this.Text = "Calculadora";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton rBtnSuma;
        private System.Windows.Forms.RadioButton rBtnResta;
        private System.Windows.Forms.RadioButton rBtnDivision;
        private System.Windows.Forms.RadioButton rBtnMultiplicacion;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label operador;
        private System.Windows.Forms.Label msj;
    }
}

