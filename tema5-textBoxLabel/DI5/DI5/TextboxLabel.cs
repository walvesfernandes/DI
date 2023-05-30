using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DI5.TextboxLabel;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DI5
{
        [
        DefaultProperty("TextLbl"),
        DefaultEvent("Load")
        ]
    public partial class TextboxLabel : UserControl
    {
        public TextboxLabel()
        {
            InitializeComponent();
            TextLbl = Name;
            TextTxt = "";
            recolocar();
        }

        //Indica donde está la etiqueta respecto al TextBox
        public enum ePosicion
        {
            IZQUIERDA, DERECHA
        }

        private ePosicion posicion = ePosicion.IZQUIERDA;
        private int separacion = 0;

        //Para hacer un override de un atributo basta hacer un get y un set del atributo que queremos que coja con los valores
        //que pasamos al componente que creamos
        [Category("Appearance")]
        [Description("Texto asociado a la Label del control")]
        public string TextLbl
        {
            set
            {
                lbl.Text = value;
                recolocar();

             
            }
            get
            {
                return lbl.Text;
            }
        }

        public event System.EventHandler TxtChanged;
        public string TextTxt
        {

            set { 
                txt.Text = value;
               
            }
            get{
                return txt.Text;
            }




        }

        [Category("La propiedad cambió")]
        [Description("Se lanza cuando la propiedad Posición cambia")]
        public event System.EventHandler CambiaPosicion;


        [Category("Appearance")]
        [Description("Indica si la Label se sitúa a la IZQUIERDA o DERECHA delTextbox")]
        public ePosicion Posicion
        {
            set
            {
                if (Enum.IsDefined(typeof(ePosicion), value))
                {
                    posicion = value;
                    recolocar(); 
                    CambiaPosicion?.Invoke(this, EventArgs.Empty);
                }
                else
                {
                    throw new InvalidEnumArgumentException();
                }
            }
            get
            {
                return posicion;
            }
        }

        [Category("Appearance")]
        [Description("Caracter para ocultar la contraseña")]
        public char PswChr { 
        
        set { 
                txt.PasswordChar= value;
            }
            
        get
            {
                return txt.PasswordChar;
            }
        
        }

        //Pixeles de separación entre label y textbox

        [Category("Design")]
        [Description("Píxels de separación entre Label y Textbox")]
        public event System.EventHandler CambiaSeparacion;
        public int Separacion
        {
            set
            {
                if (value >= 0)
                {
                    separacion = value;
                    recolocar();
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
            get
            {
                return separacion;
            }
        }


        private void recolocar()
        {
            switch (posicion)
            {
                case ePosicion.IZQUIERDA:
                    //Establecemos posición del componente lbl
                    lbl.Location = new Point(0, 0);// Establecemos posición componente txt
            txt.Location = new Point(lbl.Width + Separacion, 0);
                    //Establecemos ancho del Textbox
                    //(la label tiene ancho por autosize)
                    txt.Width = this.Width - lbl.Width - Separacion;
                    //Establecemos altura del componente
                    this.Height = Math.Max(txt.Height, lbl.Height);
                    break;
                case ePosicion.DERECHA:
                    //Establecemos posición del componente txt
                    txt.Location = new Point(0, 0);
                    //Establecemos ancho del Textbox
                    txt.Width = this.Width - lbl.Width - Separacion;
                    //Establecemos posición del componente lbl
                    lbl.Location = new Point(txt.Width + Separacion, 0);
                    //Establecemos altura del componente (Puede sacarse del switch)
                    this.Height = Math.Max(txt.Height, lbl.Height);
                    break;
            }
        }
        // Esta función has de enlazarla con el evento SizeChanged.
        // Sería necesario también tener en cuenta otros eventos como FontChanged
        // que aquí nos saltamos.
        protected override void OnSizeChanged(EventArgs e)
        {
         //   base.OnSizeChanged(e);
            recolocar();
        }

        private void txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.OnKeyPress(e);
        }

        private void TextboxLabel_Load(object sender, EventArgs e)
        {

        }

        private void TextboxLabel_KeyUp(object sender, KeyEventArgs e)
        {
            this.OnKeyUp(e);
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            recolocar();
            e.Graphics.DrawLine(new Pen(Color.Violet),
            lbl.Left, this.Height - 1, lbl.Left + lbl.Width, this.Height-1);
        } 
        private void txt_TextChanged(object sender, EventArgs e)
        {
            if (TxtChanged != null)
            {
                TxtChanged(this, new EventArgs());
            }
        }
    }
}
