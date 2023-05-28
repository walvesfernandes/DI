using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tema4_ejercicio_6
{
    public partial class FormPin : Form
    {
        int intento = 2;
        string psw = "1234";
        public FormPin()
        {
            InitializeComponent();
        }

        private void FormPin_Load(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            comprobacion();
        }

        private void comprobacion()
        {

            msjError.Text = "";
            if (intento>=1)
            {

            if (textBox1.Text.Equals(psw))
            {
                    this.DialogResult = DialogResult.OK;
            }
            else
            {
                intento--;
                 
                msjError.Text = "Pin incorrecto vuelva a intentarlo, numero de intentos:"+(intento+1);
            }
            }
            else
            {
                this.DialogResult = DialogResult.No;
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

            this.DialogResult = DialogResult.Cancel;
        }
    }
}
