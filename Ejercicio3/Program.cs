namespace Ejercicio3
{
    internal class Program
    {

        static string nombre0="";
        static int numeroLibreta0;

        static string nombre1 = "";
        static int numeroLibreta1;

        static string nombre2 = "";
        static int numeroLibreta2;

        static int orden = 0;

        static void MostrarPantallaSolicitarAlumnos()
        {
            string nombre = "";
            for (orden = 0; orden < 3; orden++)
            {
                Console.Clear();
                Console.WriteLine($"Ingrese Nombre de Alumno {orden+1}\n");
                nombre = Convert.ToString(Console.ReadLine());

                Console.WriteLine($"Ingrese Libreta de Alumno {orden+1}\n");
                int libreta = Convert.ToInt32(Console.ReadLine());
                RegistrarNombreYNumeroLibreta(nombre,libreta);
            }

        }

        static void RegistrarNombreYNumeroLibreta(string nombre, int numeroLibreta)
        {
            switch (orden)
            {
                case 0:
                    nombre0 = nombre;
                    numeroLibreta0 = numeroLibreta;
                    break;
                case 1:
                    nombre1 = nombre;
                    numeroLibreta1 = numeroLibreta;
                    break;
                case 2:
                    nombre2 = nombre;
                    numeroLibreta2 = numeroLibreta;
                    break;

            }
        }
        static void MostrarPantallaMostrarListaOrdenada()
        {
            Console.Clear();
            if (numeroLibreta0 <= numeroLibreta1 && numeroLibreta0 <= numeroLibreta2)
            {
                if (numeroLibreta1 <= numeroLibreta2)
                {
                    Console.WriteLine($"El orden es: \n{nombre0}:{numeroLibreta0}\n{nombre1}:{numeroLibreta1}\n{nombre2}:{numeroLibreta2}\n");
                }
                else
                {
                    Console.WriteLine($"El orden es: \n{nombre0}:{numeroLibreta0}\n{nombre2}:{numeroLibreta2}\n{nombre1}:{numeroLibreta1}\n");
                }
            }
            else if (numeroLibreta1 <= numeroLibreta0 && numeroLibreta1 <= numeroLibreta2)
            {
                if (numeroLibreta0 <= numeroLibreta2)
                {
                    Console.WriteLine($"El orden es: \n{nombre1}:{numeroLibreta1}\n{nombre0}:{numeroLibreta0}\n{nombre2}:{numeroLibreta2}\n");
                }
                else
                {
                    Console.WriteLine($"El orden es: \n{nombre1}:{numeroLibreta1}\n{nombre2}:{numeroLibreta2}\n{nombre0}:{numeroLibreta0}\n");
                }
            }
            else
            {
                if (numeroLibreta0 <= numeroLibreta1)
                {
                    Console.WriteLine($"El orden es: \n{nombre2}:{numeroLibreta2}\n{nombre0}:{numeroLibreta0}\n{nombre1}:{numeroLibreta1}\n");
                }
                else
                {
                    Console.WriteLine($"El orden es: \n{nombre2}:{numeroLibreta2}\n{nombre1}:{numeroLibreta1}\n{nombre0}:{numeroLibreta0}\n");
                }
            }

        }
        static void MostrarPantallaSolicitarOpcionMenu()
        {

            int opcion = 0;


            do
            {
                Console.Clear();

                Console.WriteLine("\t\t-- Ejercicio 3 --\r\n" +
                    "(1) Registrar las notas de los tres alumnos\r\n" +
                    "(2) Mostrar lista ordenada\r\n" +
                    "(-1) Finalizar Programa\r\n"
                    );

                opcion = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                if (opcion != -1)
                    switch (opcion)
                    {
                        case 1:
                            MostrarPantallaSolicitarAlumnos();
                            Console.WriteLine("Presione una tecla para continuar\n");
                            Console.ReadKey();
                            break;
                        case 2:
                            MostrarPantallaMostrarListaOrdenada();
                            Console.WriteLine("Presione una tecla para continuar\n");
                            Console.ReadKey();
                            break;
                    }
            } while (opcion != -1);


        }

        static void Main(string[] args)
        {
            MostrarPantallaSolicitarOpcionMenu();

            Console.WriteLine("Programa Finalizado \n");
        }
    }
}
