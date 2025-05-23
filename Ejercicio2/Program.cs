using Microsoft.Win32;
using System.Threading;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Ejercicio_2
{
    internal class Program
    {
        static double montoTotal = 0;
        static int[] edadNinia = new int[4] { 0, 0, 0, 0 };
        static double[] porcentajeNinia = new double[4] { 0, 0, 0, 0 };
        static double[] montoNinia = new double[4] { 0, 0, 0, 0 };
        static int edadTotal = 0;
        static void RegistrarMontoARepartir(double monto)
        {
            montoTotal = monto;
        }

        static void MostrarPantallaSolicitarMontoArepartir()
        {
            Console.Clear();
            Console.WriteLine("Ingrese el monto a repartir: ");
            RegistrarMontoARepartir(Convert.ToDouble(Console.ReadLine()));
        }

        static void RegistrarEdad(int edad, int nNinia)
        {
            edadNinia[nNinia] = edad;
            edadTotal += edad;
        }
        static void MostrarPantallaSolicitarEdadDeNinias()
        {
            edadTotal = 0;
            for (int i = 0; i < 4; i++)
            {
                Console.Clear();
                Console.WriteLine("Ingrese la edadd de la ninia :"+ (Convert.ToInt32(i + 1)));
                RegistrarEdad(Convert.ToInt32(Console.ReadLine()), i);

            }
        }

        static void CalcularMontosYPorcentajesARepartir()
        {
            if (edadTotal != 0)
            {
                for (int i = 0; i < 4; i++)
                {

                    porcentajeNinia[i] = Convert.ToDouble(edadNinia[i]) / edadTotal;

                    montoNinia[i] = porcentajeNinia[i] * montoTotal;
                }
            }

        }

        static void MostrarEnPantallaMontosARepartir()
        {

            if (edadTotal != 0)
            {
                Console.WriteLine($"Monto Total a Repartir: {Math.Round(montoTotal, 2)}\n");
                for (int i = 0; i < 4; i++)
                {
                    Console.WriteLine($"Ninia {(Convert.ToInt32(i + 1))}, edad {edadNinia[i]},monto: ${Math.Round(montoNinia[i], 2)}\n");
                }
            }
            else
            { 
                Console.WriteLine("Debe Ingresar Valores de Edad"); 
            }
        }


        static int MostrarPantallaSolicitarOpcionMenu()
        {

            Console.WriteLine("\t\t-- Ejercicio 2 --\r\n" +
                "(1) Iniciar Monto a repartir\r\n" +
                "(2) Solicitar Edad Por niña\r\n" +
                "(3) Mostrar monto y porcentajes que corresponde a cada niña\r\n" +
                "(-1) Finalizar Programa\r\n"
                );

            return Convert.ToInt32(Console.ReadLine());
        }
        static void Main(string[] args)
        {
            
            int opcion = 0;


            do
            {
                Console.Clear();
                opcion = MostrarPantallaSolicitarOpcionMenu();
                Console.Clear();
                if (opcion != -1)
                    switch (opcion)
                    {
                        case 1:
                            MostrarPantallaSolicitarMontoArepartir();
                            Console.WriteLine("Presione una tecla para continuar\n");
                            Console.ReadKey();
                            break;
                        case 2:
                            MostrarPantallaSolicitarEdadDeNinias();
                            Console.WriteLine("Presione una tecla para continuar\n");
                            Console.ReadKey();
                            break;
                        case 3:
                            CalcularMontosYPorcentajesARepartir();
                            MostrarEnPantallaMontosARepartir();
                            Console.WriteLine("Presione una tecla para continuar\n");
                            Console.ReadKey();
                            break;
                    }
            } while (opcion != -1);


            Console.WriteLine("Programa Finalizado \n");


        }
    }
}