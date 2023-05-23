using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Ejercicio 3 
    Se abre un formulario en el mediante un botón se saca un OpenFileDialog (Ver apéndice III) en el que 
    se verán diversos archivos de imagen (al menos jpg y png) además de todos los archivos. Debe haber 
    también checkbox con la palabra Modal como texto. Una vez pulsado el usuario seleccione una 
    imagen y le de Aceptar en el OpenFIleDialog se deben hacer las siguientes tareas:
    • Se saca un segundo formulario del tamaño de la imagen y se muestra la imagen en dicho 
    formulario. Si cambias el tamaño del formulario debe cambiar también el de la imagen de 
    fondo deformándose (Usa un picturebox). El formulario será modal si el checkbox está 
    marcado y no modal en caso contrario.
    • El Dtulo del formulario secundario será el nombre de la imagen (sin el path) y el del principal 
    “Visor de imágenes“
    • Se debe pedir con8rmación antes de salir del programa.
 * */

namespace Ejer_3_tema_4
{
    public partial class Form1 : Form
    {
        private Form imageForm;
        private PictureBox pictureBox;
        private CheckBox modalCheckBox;
        private string selectedImagePath;

        public Form1()
        {

            //Creacion de componentes en tiempo de ejecucion
            modalCheckBox = new CheckBox();
            modalCheckBox.Text = "Modal";
            modalCheckBox.Location = new Point(12, 12);
            this.Controls.Add(modalCheckBox);

            Button openBtn = new Button();
            openBtn.Text = "Abrir imagen";
            openBtn.Location = new Point(12, 40);
            openBtn.Click += OpenButton_Click;
            this.Controls.Add(openBtn);
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void OpenButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png|Todos los archivos|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                selectedImagePath = openFileDialog.FileName;
                ShowImageForm();
            }
        }

        private void ShowImageForm()
        {
            if (imageForm != null)
            {
                imageForm.Close();
                imageForm.Dispose();
            }

            imageForm = new Form();
            imageForm.Text = "Visor de imágenes";
            imageForm.FormBorderStyle = FormBorderStyle.FixedSingle;
            imageForm.StartPosition = FormStartPosition.CenterScreen;

            pictureBox = new PictureBox();
            pictureBox.Image = Image.FromFile(selectedImagePath);
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.Dock = DockStyle.Fill;
            imageForm.Controls.Add(pictureBox);

            if (modalCheckBox.Checked)
                imageForm.ShowDialog();
            else
                imageForm.Show();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Está seguro de que desea salir?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                if (imageForm != null)
                {
                    imageForm.Close();
                    imageForm.Dispose();
                }

                base.OnFormClosing(e);
            }
        }
    
}
}
