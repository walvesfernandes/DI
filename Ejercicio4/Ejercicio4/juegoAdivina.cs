using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    /*Opción 2. Juego adivina un número. El ordenador saca un número aleatorio entre 1 y 100. El usuario 
        tiene 5 intentos para adivinarlo.Se informa mayor/menor en cada intento así como el número de 
        intentos restantes. */
    internal class juegoAdivina
    {
        Random random = new Random();

        public void numAleatorio()
        {
            int intentos = 5;
            int num = random.Next(1, 101);


            Console.WriteLine("Introduzca un numero entre 1 y 100.\nTienes {0} intentos", intentos);


            while (intentos > 0)
            {

                if (Int32.TryParse(Console.ReadLine(), out int numUsuario))
                {
                    intentos--;
                    if (numUsuario == num)
                    {
                        Console.WriteLine("Has acertado el numero!!!\nEl numero era: {0}", num);
                    }
                    else if (numUsuario < num)
                    {

                        Console.WriteLine(String.Format("Valor muy bajo, intentalo otra vez.\nNumero de intentos:{0}", intentos));

                    }
                    else if (numUsuario > num)
                    {
                        Console.WriteLine(String.Format("Valor muy alto, intentalo otra vez.\nNumero de intentos:{0}", intentos));


                    }


                }
                else
                {
                    Console.WriteLine("No has introducido un numero.");
                }

            }
            Console.WriteLine(String.Format("El numero era: {0}", num));









        }
    }
}
