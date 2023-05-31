using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EtiquetaAviso
{
    public enum eMarca
    {
        Nada,
        Cruz,
        Circulo
    }
    public partial class EtiquetaAviso : Control
    {

        public EtiquetaAviso()
        {
            InitializeComponent();
            this.Text = "Etiqueta aviso";
        }
        private bool gradiente = false;
        [Category("Apperance")]
        [Description("Pon un fondo grandiante al componente")]
        public bool Gradiente
        {

            set {
                gradiente = value;
                this.Refresh();
            }
            get
            {
                return gradiente;
            }
        }
        Color colorInicial = Color.White;
        [Category("Appearance")]
        [Description("Color inicial del gradiente")]
        public Color ColorInicial
        {

            set
            {
                colorInicial = value;
                this.Refresh();
            }
            get
            {
                return colorInicial;
            }
        }


        Color colorFinal = Color.White;
        [Category("Appearance")]
        [Description("Color final del gradiente")]
        public Color ColorFinal
        {

            set
            {
                colorFinal = value;
                this.Refresh();
            }
            get
            {
                return colorFinal;
            }
        }

        private eMarca marca = eMarca.Nada;
        [Category("Appearance")]
        [Description("Indica el tipo de marca que aparece junto al texto")]
        public eMarca Marca{
            set {

                marca = value;
                this.Refresh();
            }
            get
            {
                return marca;
            }


        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Graphics g = e.Graphics;
            //Gradiente
            if (gradiente)
            {
                //ClientRectangle devuelve un objeto Rectangle que tiene las coordenadas del rectangulo de la area del componente
                using (LinearGradientBrush brush = new LinearGradientBrush(ClientRectangle, colorInicial, colorFinal, LinearGradientMode.Horizontal))
                {


                    g.FillRectangle(brush, ClientRectangle);

                }
            }
            else
            {
                using (var brush = new SolidBrush(BackColor))
                {
                    g.FillRectangle(brush, ClientRectangle);

                }
            }
         

            int grosor = 0; //Grosor de las líneas de dibujo
            int offsetX = 0; //Desplazamiento a la derecha del texto
            int offsetY = 0; //Desplazamiento hacia abajo del texto
                             // Altura de fuente, usada como referencia en varias partes
            int h = this.Font.Height;
            //Esta propiedad provoca mejoras en la apariencia o en la eficiencia 
            // a la hora de dibujar
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            //Dependiendo del valor de la propiedad marca dibujamos una
            //Cruz o un Círculo
            switch (Marca)
            {
                case eMarca.Circulo:
                    grosor = 20;
                    g.DrawEllipse(new Pen(Color.Green, grosor), grosor, grosor,
                    h, h);
                    offsetX = h + grosor;
                    offsetY = grosor;
                    break;
                case eMarca.Cruz:
                    grosor = 3;
                    Pen lapiz = new Pen(Color.Red, grosor);
                    g.DrawLine(lapiz, grosor, grosor, h, h);
                    g.DrawLine(lapiz, h, grosor, grosor, h);
                    offsetX = h + grosor;
                    offsetY = grosor / 2;
                    //Es recomendable liberar recursos de dibujo pues se 
                    //pueden realizar muchos y cogen memoria
                    lapiz.Dispose();
                    break;
            }
            //Finalmente pintamos el Texto; desplazado si fuera necesario
            SolidBrush b = new SolidBrush(this.ForeColor);
            g.DrawString(this.Text, this.Font, b, offsetX + grosor, offsetY);
            Size tam = g.MeasureString(this.Text, this.Font).ToSize();
            this.Size = new Size(tam.Width + offsetX + grosor, tam.Height + offsetY * 2);
            b.Dispose();

        }
        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);
            this.Refresh();
        }

    }
}
