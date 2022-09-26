using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {

            double resultDouble;

            result.Text = "=";


            if ((double.TryParse(textBox1.Text, out double lbl1)) && (double.TryParse(textBox2.Text, out double lbl2))) { 
                resultDouble = Math.Truncate((Convert.ToDouble(textBox1.Text) + Convert.ToDouble(textBox2.Text)))/10; //hago un truncate para mostrar los decimales
                result.Text = String.Format("{0}", resultDouble);
            }
            else
            {
                result.Text = "Debes inserir un numero";
            }


        }
    }
}
