namespace Ejercicio4
{
    internal class Program
    {
        /* Ejercicio 4
             Realizar en modo consola un menú con 3 opciones(juegos) utilizando estructuración mediante
             funciones(al menos cada juego una función). Al final de cada opción se debe preguntar al usuario si
             desea volver a ejecutar dicha opción sin volver al menú inicial:

             Opción 1. Pedir un número al usuario del 1 al X, tirar diez dados mostrando el resultado de cada uno e
             informar al usuario de cuantas veces ha acertado.X es un parámetro que si no se pasa se inicializa
             por defecto a 6.

             Opción 2. Juego adivina un número.El ordenador saca un número aleatorio entre 1 y 100. El usuario
             tiene 5 intentos para adivinarlo.Se informa mayor/menor en cada intento así como el número de
             intentos restantes.

             Opción 3. Realizar una quiniela: Se deben dar 14 resultados aleatorios como 1, X ó 2 de forma
             ponderada.La probabilidad de sacar 1 sea del 60%, la de sacar X sea 25% y la de sacar un 2 sea un 
             15%. Se debe realizar al menos una función que devuelva un 1 una X o un 2 ponderado de la forma
             anterior., sacando un número de 1 a 100 y seleccionando el valor devuelto con un switch con clausula
             when.

             Opción 4. Jugar a todos.El programa pasará por los 3 apartados anteriores. No se puede llamar
             simplemente a funciones, es necesario jugar con goto case. 
             Opción 5. Salir.Mientras no se seleccione esta opción, el ordenador se mantendrá en el programa.*/
        static void Main(string[] args)
        {


            juegos();


        }

        static public void juegos()
        {
            bool salir = false;
            Dados dados = new Dados();
            juegoAdivina advina = new juegoAdivina();
            Quiniela quiniela = new Quiniela();



            do
            {
                Console.WriteLine(String.Format("Elija una opción de juego:\n1.-Juego tirar dados\n2.-Juego advina un número\n3.-Quiniela\n4.-Jugar los 3 anteriores"));
                if (Int32.TryParse(Console.ReadLine(), out int opcion))
                {

                    switch (opcion)
                    {
                        case 1:
                            dados.LanzarDados();
                            break;
                        case 2:
                            advina.numAleatorio();
                            break;
                        case 3:
                            quiniela.quinielaJuego();
                            break;
                        case 5:
                            Console.WriteLine("Programa finalizado.");
                            salir = true;
                            break;
                        default:
                            break;
                    }



                }
                else
                {
                    Console.WriteLine("Debes introducir una opción valida.");
                }



            } while (!salir);


        }

    }


}