namespace Ejercicio4
{
    internal class Program
    {
        static string? jugador1="";
        static int setGanados1=0;
        static string? jugador2= "";
        static int setGanados2=0;

        static void RegistrarJugadores(string nombre1,string nombre2)
        {
            jugador1 = nombre1;
            jugador2 = nombre2;
        }
        static void RegistrarResultadoSet(int resultado1, int resultado2)
        {
            if (resultado1 > resultado2)
            {
                setGanados1++;
            }
            else
            {
                setGanados2++;
            }
        }

        static string DeterminarGanador()
        {
            string res = "";
            
            if(setGanados1>setGanados2)
            {
                res = "Ganador Jugador 1";
            }
            else
            {
                res = "Ganador Jugador 2";
            }
            return res;
        }

        static void MostrarPantallaSolicitarNombreJugadores()
        {
            Console.Clear();
            Console.WriteLine("Ingrese Nombre Jugador 1: ");
            jugador1 = Console.ReadLine();
            Console.WriteLine("\nIngrese Nombre Jugador 2: ");
            jugador2 = Console.ReadLine();

            RegistrarJugadores(jugador1, jugador2);
        }
        static void ProcesarSet(int set)
        {

            Console.Clear();
            int puntos1, puntos2;
            Console.WriteLine($"SET {set}: ");
            Console.WriteLine("Ingrese Puntos Jugador 1: ");
            puntos1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nIngrese Puntos Jugador 2: ");
            puntos2 = Convert.ToInt32(Console.ReadLine());

            RegistrarResultadoSet(puntos1, puntos2);
        }

        static void MostrarPantallaSolicitarResultadoSet()
        {
            if((jugador1!="" &&  jugador2!=""))
            {

                ProcesarSet(1);
                ProcesarSet(2);
                ProcesarSet(3);
            }
            else
            {
                Console.Clear();
                Console.WriteLine("No se ha registrado jugador aun\n");
            }
        }

        static void MostrarPantallaGanador()
        {
            if ( (setGanados1 != 0 || setGanados2 != 0))
            {

                Console.Clear();
                Console.WriteLine(DeterminarGanador());
            }
            else
            {
                Console.Clear();
                Console.WriteLine("No se ha jugado aun\n");
            }

        }

        static void MostrarPantallaSolicitarOpcionMenu()
        {

            int opcion = 0;


            do
            {
                Console.Clear();

                Console.WriteLine("\t\t-- Ejercicio 4 --\r\n" +
                    "(1) Registrar nombre de los dos jugadores.\r\n" +
                    "(2) Registrar los resultados de cada set de los jugadores.\r\n" +
                    "(3) Mostrar el ganador.\r\n" +
                    "(-1) Finalizar Programa\r\n"
                    );

                opcion = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                if (opcion != -1)
                    switch (opcion)
                    {
                        case 1:
                            MostrarPantallaSolicitarNombreJugadores();
                            Console.WriteLine("Presione una tecla para continuar\n");
                            Console.ReadKey();
                            break;
                        case 2:
                            MostrarPantallaSolicitarResultadoSet();
                            Console.WriteLine("Presione una tecla para continuar\n");
                            Console.ReadKey();
                            break;
                        case 3:
                            MostrarPantallaGanador();
                            Console.WriteLine("Presione una tecla para continuar\n");
                            Console.ReadKey();
                            break;
                    }
            } while (opcion != -1);

        }
        static void Main(string[] args)
        {
            MostrarPantallaSolicitarOpcionMenu();
            Console.WriteLine("Programa Finalizado\n");
        }
    }
}
