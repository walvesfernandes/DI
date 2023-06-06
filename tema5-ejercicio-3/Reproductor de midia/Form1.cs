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

namespace Reproductor_de_midia
{
    public partial class Form1 : Form
    {
        Timer timer;
        private string[] imagenes;
        private int indiceActual;
        private int tiempoTranscurrido;

        public Form1()
        {
            InitializeComponent();
            timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
        }

        private void ActualizarTiempo()
        {
            int minutos = tiempoTranscurrido / 60; // divide tiempoTranscurrido por 60 para conseguir la cantidad de minutos.
            int segundos = tiempoTranscurrido % 60;
            reproductor1.Minutos = minutos;
            reproductor1.Segundos = segundos;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            tiempoTranscurrido++;
            ActualizarTiempo();

            MostrarImagenSiguiente();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
   
        private void MostrarImagenSiguiente()
        {
            if (imagenes != null && imagenes.Length > 0)
            {
                string imagenActual = imagenes[indiceActual];
                indiceActual = (indiceActual + 1) % imagenes.Length;
                pictureBox1.Image = Image.FromFile(imagenActual);
            }
        }
        private void btnDirectorio_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog carpeta = new FolderBrowserDialog())
            {
                if (carpeta.ShowDialog() == DialogResult.OK)
                {
                    string rutaDirectorio = carpeta.SelectedPath;
                    imagenes = Directory.GetFiles(rutaDirectorio, "*.jpg");
                }
            }
        }

        private void reproductor1_PulsacionBoton(object sender, EventArgs e)
        {
            if (timer.Enabled)
            {
                timer.Stop();
            }
            else
            {
                timer.Start();
            }
        }

        private void reproductor1_DesbordarTiempo(object sender, EventArgs e)
        {
            reproductor1.Minutos++;
        }
    }
}
