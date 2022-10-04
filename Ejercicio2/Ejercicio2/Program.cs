#define FRASES
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ejercicio2 e2 = new Ejercicio2();
            e2.pedirFrases();
            Console.ReadLine();

        }
    }


    class Ejercicio2
    {


        public void  pedirFrases() {
            string frase1 = "";
            string frase2 = "";

            for (int i = 1; i < 3; i++)
            {
                Console.WriteLine($"Introduzca {i}º frase:");
                if (i==1) { 
                frase1= Console.ReadLine();
                }
                if (i == 2) { 
                    frase2 = Console.ReadLine(); 
                }
              }

            #if FRASE
                 Console.WriteLine(String.Format("\"{0}\" \\{1}\\", frase1,frase2));
            #else
                 Console.WriteLine(String.Format("{0}\t{1}\n{0}\n{1}",frase1,frase2));
            #endif
        }
        

        }

        


    }

