#define RESTA

namespace Ejercicio3
{
    public partial class Form1 : Form
    {
        Random generador = new Random();
        int credito = 10;
        public Form1()
        {

            InitializeComponent();
            lblTotalCred.Text = credito.ToString();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnJugar_Click(object sender, EventArgs e)
        {
            int txt1 = generador.Next(1, 8);
            int txt2 = generador.Next(1, 8);
            int txt3 = generador.Next(1, 8);


            textBox1.Text = txt1.ToString();
            textBox2.Text = txt2.ToString();
            textBox3.Text = txt3.ToString();


            verificarNum(txt1, txt2, txt3);

        }

        public void verificarNum(int num1, int num2, int num3)
        {

            premio.Text = "";

            if (credito > 0)
            {

                if (num1 == num2 && num3 == num1)
                {
                    credito += 20;
                    premio.Text = "Premio de 20 Euros";


                }
                else if (num1 == num2 || num1 == num3 || num2 == num3)
                {

#if RESTAS
                    credito -= 5;
#else
                    credito += 5;
                    premio.Text = "Premio de 5 Euros";

#endif

                }


                credito -= 2;

            }
            else
            {
                credito = 0;

            }

            if (credito < 2)
            {
                btnJugar.Enabled = false;
                btnLimosna.Enabled = true;

            }
            else
            {
                btnJugar.Enabled = true;
            }
            lblTotalCred.Text = credito.ToString();

        }

        private void btnLimosna_Click(object sender, EventArgs e)
        {
            credito += 10;
            btnJugar.Enabled = true;
            lblTotalCred.Text = credito.ToString();

        }
    }
}