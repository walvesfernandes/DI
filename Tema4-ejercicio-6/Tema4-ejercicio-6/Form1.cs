using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tema4_ejercicio_6
{
    public partial class Form1 : Form
    {
        private Color controlColor;
        private Color colorClick;
        public Form1()
        {

            int x=23;
            int y = 99;
            InitializeComponent();

            controlColor = textBox1.BackColor;
            colorClick = SystemColors.ControlDark;
            //BTN reset
            Button btnReset = new Button();
            btnReset.Location = new Point(23, 65);
            btnReset.Name = "buttonReset";
            btnReset.Size = new Size(46, 23);
            btnReset.Text ="Reset";
            btnReset.Click += borrarInput;
            this.Controls.Add(btnReset);
            
            //Bucle para creacion de componentes en tiempo de ejecucion
            for (int i = 1; i <= 12; i++)
            {
            Button button = new Button();
            button.Location = new Point(x, y);
            button.Name = "button"+i;
            button.Size = new Size(40, 38);
            button.TabIndex = i;
            button.Text = i.ToString();
            //eventos
            button.Click += clickBtn;
            button.MouseEnter += mouseEnter;
            button.MouseLeave += mouseLeave;
            button.MouseDown += clickColor;
            this.Controls.Add(button);
                x += 45;
                if (i % 3==0)
                {
                    x = 23;
                    y += 49; ;
                }
                if (i==10) {
                    button.Name = "asterico";
                    button.Text = "*";
                }
                if (i == 11)
                {
                    button.Name = "0";
                    button.Text = "0";
                }
                if (i == 12)
                {
                    button.Name = "hashtag";
                    button.Text = "#";
                }

            }
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            FormPin formPin =new FormPin();
            DialogResult result;
            result = formPin.ShowDialog();

            switch (result)
            {
                case DialogResult.OK:

                            MessageBox.Show("Contraseña Aceptada", "Movil",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                        break;
                case DialogResult.Cancel:

                            MessageBox.Show("La aplicacion se va a cerrar", "Movil",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            this.Close();

                    break;
                case DialogResult.No:
                    
                        MessageBox.Show("Ya no queda intentos", "Pin invalido",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.Close();

                    break;
                default:
                    break;
            }
            
        }

        private void clickBtn(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            textBox1.Text += btn.Text.ToString();

        }

        private void mouseEnter(object sender, EventArgs e)
        {

            Button btn = (Button)sender;
            if (btn.BackColor != colorClick)
            {
                btn.BackColor = SystemColors.ActiveCaption;
            }
 
        }

        private void mouseLeave(object sender, EventArgs e)
        {

            Button btn = (Button)sender;

            if (btn.BackColor != colorClick) { 
            
            btn.BackColor = controlColor;
            }
        
        }

        private void clickColor(object sender, MouseEventArgs e) {

            Button btn = (Button)sender;
            btn.BackColor = colorClick;

        }

        private void borrarInput(object sender, EventArgs e)
        {
            textBox1.Text = "";
            foreach (var item in this.Controls)
            {

                if (item is Button)
                {

                    Button btn = (Button)item;
                    btn.BackColor = controlColor;
                }
            }
        }

        private void grabarNumeroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
                saveFileDialog.Title = "Guardar número en archivo de texto";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string ruta = saveFileDialog.FileName;
                    File.WriteAllText(ruta, textBox1.Text);
                    MessageBox.Show("Número guardado en el archivo: " + ruta);
                }
            }
            else
            {
                MessageBox.Show("Sin número para grabar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.borrarInput(sender, e);
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Autor: Willian A. Fernandes", "Información de la app",
                          MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
