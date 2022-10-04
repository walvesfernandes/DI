using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    /* Opción 1. Pedir un número al usuario del 1 al X, tirar diez dados mostrando el resultado de cada uno e
       informar al usuario de cuantas veces ha acertado.X es un parámetro que si no se pasa se inicializa
       por defecto a 6.*/
    internal class Dados
    {

        Random r = new Random();
        public void LanzarDados() {
            int numJugador=6;
            int dado;
            int resultado=0;

            Console.WriteLine("Introduzca un numero de 1 a 50");

            if (Int32.TryParse(Console.ReadLine(), out int result)) {
                numJugador = result;
            }
        


            for (int i = 1; i < 11; i++)
            {
                dado =r.Next(1,6);
                Console.WriteLine(String.Format("Dado {0} numero: {1}", i, dado));
                if (dado==numJugador)
                {
                    resultado++;
                }
            }


            Console.WriteLine(String.Format("\nTu numero era: {0}\nHas acertado:{1}",numJugador,resultado));
            Console.ReadLine();

        }


    }
}
