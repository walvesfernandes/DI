using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio3DI
{
    public partial class Ejer3 : Form
    {
        public Ejer3()
        {
            InitializeComponent();
        }

        private void btnSalir(object sender, EventArgs e)
        {
            if (MessageBox.Show("Realmente quieres cerrar el formulario?", "Alerta", MessageBoxButtons.OKCancel) == DialogResult.OK) this.Close();

        }

        private void cambiarColor()
        {

            Color miColor = new Color();

            try
            {
                msjError.Text = "";
                int r = Convert.ToInt32(color1.Text);
                int g = Convert.ToInt32(color2.Text);
                int b = Convert.ToInt32(color3.Text);


                miColor = Color.FromArgb(r, g, b);

                this.BackColor = miColor;

            }
            catch (Exception ex) when (ex is FormatException || ex is OverflowException || ex is ArgumentException)
            {

                msjError.ForeColor = Color.Red;
                msjError.BackColor = Color.White;
                msjError.Text = "Has introducido un dato incorrecto.";
            }


        }

        private void btnCambiar_Click(object sender, EventArgs e)
        {
            cambiarColor();
        }

        private void btnCambiar_MouseEnter(object sender, EventArgs e)
        {
            if (sender is Button)
            {

                Button btn = (Button)sender;

                if (btn.BackColor == SystemColors.Control)
                {

                    btn.BackColor = Color.Aqua;
                }
                else
                {
                    btn.BackColor = SystemColors.Control;
                }


            }

        }


        private void mouseTitle(object sender, MouseEventArgs e)
        {
            Control c = new Control();
            c = (Control)sender;


            //si contiene este componenete 
            if (this.Controls.Contains(c))
            {

                int cx = c.Location.X;
                int cy = c.Location.Y;

                this.Text = "X:" + (cx + e.Location.X) + "Y:" + (cy + e.Location.Y);

            }
            else
            {

                this.Text = "X:" + e.Location.X + " Y:" + e.Location.Y;

            }
        }

        private void Ejer3_MouseLeave(object sender, EventArgs e)
        {
            cambiarTitulo();
        }


        private void verImg(object sender, EventArgs e)
        {

            try
            {

                imgBox.Image = new Bitmap(imgRutaTxt.Text);

            }
            catch (ArgumentException)
            {

                msjError.ForeColor = Color.Red;
                msjError.BackColor = Color.White;
                msjError.Text = "No has introducido ningun dato o has introducido un dato incorrecto.";

            }

        }

        private void Ejer3TeclaT(object sender, KeyEventArgs e)
        {

            if (e.KeyValue == 't')
            {
                cambiarTitulo();
            }
        }

        private void cambiarTitulo()
        {
            this.Text = "Colores e Imágenes";
        }

        private void Ejer3_MouseLeave_1(object sender, EventArgs e)
        {
            cambiarTitulo();
        }

        }
    }

