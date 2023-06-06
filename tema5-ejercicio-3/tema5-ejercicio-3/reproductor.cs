using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tema5_ejercicio_3
{
    public partial class reproductor : UserControl
    {

       private static string ruta = @"C:\Users\lpwil\source\repos\tema5-ejercicio-3\tema5-ejercicio-3\";

       private static Image pause = Image.FromFile(string.Format(@"{0}Resources\pause.png", ruta));
       private static Image play = Image.FromFile(string.Format(@"{0}Resources\play.png",ruta));

        bool tocaCancion = false;
        public reproductor()
        {
            InitializeComponent();
            playPause.Image = play;
        }

        public event EventHandler DesbordarTiempo;
        public event EventHandler PulsacionBoton;

        int segundos = 0;
        public int Segundos
        {
          
            set
            {
                segundos = value;
                if (segundos > 59)
                {
                    segundos = 0;
                    OnDesbordaTiempo(EventArgs.Empty);
                }
                ActualizarTiempo();
            }
            get { return segundos; }
        }

        int minutos = 0;
        public int Minutos
        {
            set
            {
                minutos = value;
                if (minutos > 99)
                    minutos = 0;
                ActualizarTiempo();

            }
            get
            {
                return minutos;
            }
        }

        private void ActualizarTiempo()
        {
            lblMinutos.Text = $"{minutos:D2}";
            lblSegundos.Text = $":{segundos:D2}";
        }

        private void OnPulsacionBoton(EventArgs e ) {
            PulsacionBoton?.Invoke(this,e);
        }
        private void OnDesbordaTiempo(EventArgs e)
        {
            DesbordarTiempo?.Invoke(this,e);
        }

        private void reproductor_Load(object sender, EventArgs e)
        {

        }

        private void playPause_Click(object sender, EventArgs e)
        {
          
            tocaCancion = !tocaCancion;
            playPause.Image = tocaCancion ? pause : play;
            OnPulsacionBoton(EventArgs.Empty);
        }
    }
}
