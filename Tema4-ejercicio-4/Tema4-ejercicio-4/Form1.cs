using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tema4_ejercicio_4
{
    public partial class Calculadora : Form
    {
        //delegado
        delegate double Operacion(double a, double b);
        private Dictionary<string, Operacion> operadores;
        public Calculadora()
        {
            //agrego las operaciones dentro de Diccionario para que sea mas facil la busqueda 
            operadores = new Dictionary<string, Operacion>
            {
                { "+", (a, b) => a + b },
                { "-", (a, b) => a - b },
                { "*", (a, b) => a * b },
                { "/", (a, b) => a / b }
            };
            InitializeComponent();
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void CambiarOperador(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;

            operador.Text = radioButton.Tag.ToString();
        }

        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            if (radioButton.Checked)
            {
                operador.Text = radioButton.Tag.ToString();
            }
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out double num1) &&
                double.TryParse(textBox2.Text, out double num2))
            {
                msj.Text = "";
                string operador = this.operador.Text;
                if (operadores.ContainsKey(operador))
                {
                    double result = operadores[operador](num1, num2);
                    MessageBox.Show("Resultado: " + result.ToString(), "Resultado del calculo");
                }
            }
            else
            {
                msj.Text = "Uno o todos los valores invalido.";
            }
        }

        private void cambiaColorTxtBox(object sender, EventArgs e)
        {
            //Cambia el color de fondo del texto a rojo si el valor ingresado no es un numero decimal valido
            TextBox textBox = (TextBox)sender;
            textBox.BackColor = double.TryParse(textBox.Text, out _) ? SystemColors.Window : System.Drawing.Color.Red;
        }
    }
}
