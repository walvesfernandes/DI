namespace Ejercicio3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.lblCredito = new System.Windows.Forms.Label();
            this.lblTotalCred = new System.Windows.Forms.Label();
            this.premio = new System.Windows.Forms.Label();
            this.btnJugar = new System.Windows.Forms.Button();
            this.btnLimosna = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox1.Location = new System.Drawing.Point(65, 68);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(65, 110);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 23);
            this.textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.Enabled = false;
            this.textBox3.Location = new System.Drawing.Point(65, 151);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 23);
            this.textBox3.TabIndex = 2;
            // 
            // lblCredito
            // 
            this.lblCredito.AutoSize = true;
            this.lblCredito.Location = new System.Drawing.Point(12, 48);
            this.lblCredito.Name = "lblCredito";
            this.lblCredito.Size = new System.Drawing.Size(49, 15);
            this.lblCredito.TabIndex = 5;
            this.lblCredito.Text = "Credito:";
            // 
            // lblTotalCred
            // 
            this.lblTotalCred.AutoSize = true;
            this.lblTotalCred.Location = new System.Drawing.Point(65, 48);
            this.lblTotalCred.Name = "lblTotalCred";
            this.lblTotalCred.Size = new System.Drawing.Size(13, 15);
            this.lblTotalCred.TabIndex = 6;
            this.lblTotalCred.Text = "0";
            // 
            // premio
            // 
            this.premio.AutoSize = true;
            this.premio.BackColor = System.Drawing.Color.Yellow;
            this.premio.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.premio.Location = new System.Drawing.Point(65, 9);
            this.premio.Name = "premio";
            this.premio.Size = new System.Drawing.Size(0, 17);
            this.premio.TabIndex = 9;
            // 
            // btnJugar
            // 
            this.btnJugar.Location = new System.Drawing.Point(76, 180);
            this.btnJugar.Name = "btnJugar";
            this.btnJugar.Size = new System.Drawing.Size(75, 23);
            this.btnJugar.TabIndex = 4;
            this.btnJugar.Text = "Jugar";
            this.btnJugar.UseVisualStyleBackColor = true;
            this.btnJugar.Click += new System.EventHandler(this.btnJugar_Click);
            // 
            // btnLimosna
            // 
            this.btnLimosna.Location = new System.Drawing.Point(65, 209);
            this.btnLimosna.Name = "btnLimosna";
            this.btnLimosna.Size = new System.Drawing.Size(100, 23);
            this.btnLimosna.TabIndex = 10;
            this.btnLimosna.Text = "Pedir credito";
            this.btnLimosna.UseVisualStyleBackColor = true;
            this.btnLimosna.Click += new System.EventHandler(this.btnLimosna_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(233, 354);
            this.Controls.Add(this.btnLimosna);
            this.Controls.Add(this.premio);
            this.Controls.Add(this.lblTotalCred);
            this.Controls.Add(this.lblCredito);
            this.Controls.Add(this.btnJugar);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Tragaperras";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label lblCredito;
        private Label lblTotalCred;
        private Label premio;
        private Button btnJugar;
        private Button btnLimosna;
    }
}