namespace Ejercicio1
{
    internal class Program

    {
        static int acumulador = 0;
        static int cantidad;
        static int contador = 0;
        static int valor=0;
        static double promedio = 0.0;
        static int maxValor = int.MinValue;
        static int minValor = int.MaxValue;

        static void ActualizarMax(int valor)
        {
            if (valor == 0 || valor > maxValor)
            {
                maxValor = valor;
            }
        }
        static void ActualizarMin(int valor)
        {
            if (valor == 0 || valor < minValor)
            {
                minValor = valor;
            }
        }


        static void RegistrarValor(int valor)
        {
            acumulador += valor;
            contador++;
        }

        static void CalcularPromedio()
        {
            promedio = Convert.ToDouble(acumulador) / Convert.ToDouble(contador);
            
        }

        static int MostrarPantallaSolicitarOpcionMenu()
        {
            
            Console.WriteLine("\t\t-- Ejercicio 1 --\r\n" +
                "(1) Procesar un solo número\r\n" +
                "(2) Procesar varios números\r\n" +
                "(3) Mostrar máximo y mínimo.\r\n" +
                "(4) Mostrar promedio.\r\n" +
                "(5) Mostrar cantidad de números ingresados.\r\n" +
                "(6) Reiniciar variables\r\n" +
                "(-1) Finalizar Programa\r\n"
                );

            return Convert.ToInt32(Console.ReadLine());
        }



        static void SolicitarIngresarValor()
        {
            
            Console.WriteLine($"ingrese el valor del num {contador + 1}");

            valor = Convert.ToInt32(Console.ReadLine());

            RegistrarValor(valor);
            ActualizarMax(valor);
            ActualizarMin(valor);


        }
        static void SolicitarIngresarCantidadDeNumeros()
        {
            
            Console.WriteLine("Ingrese la cantidad de numeros a ingresar.");
            cantidad = Convert.ToInt32(Console.ReadLine());
        }
        static void MostrarPantallaSolicitarVariosNumeros()
        {
            

            SolicitarIngresarCantidadDeNumeros();
            for (int n = 0; n < cantidad; n++)
            {
                SolicitarIngresarValor();
            }
        }

        static void MostrarPantallaMinimoYMaximo()
        {
            
            if (contador > 0)
            {

                Console.WriteLine("Valor minimo: " + minValor);
                Console.WriteLine("Valor maximo: " + maxValor);
            }
            else
            {
                Console.WriteLine("No se han ingresado valores");
            }
        }

        static void MostrarPantallaPromedio()
        {
            
            if (contador > 0)
            {
                CalcularPromedio();
                Console.WriteLine("Valor promedio: " + promedio);
            }
            else
            {
                Console.WriteLine("No se han ingresado valores");
            }
        }

        static void MostrarCantidadDeNumerosIngresados()
        {
            
            Console.WriteLine("Cantidad de numeros ingresados: " + contador);
        }

        static void ReiniciarVariables()
        {
            
            valor = 0;
            cantidad = 0;
            acumulador = 0;
            contador = 0;

            promedio = 0;
            maxValor = int.MinValue;
            minValor = int.MaxValue;

            Console.WriteLine("Se han reseteado los valores ingresados");
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
                            SolicitarIngresarValor();
                            Console.WriteLine("Presione una tecla para continuar\n");
                            Console.ReadKey();
                            break;
                        case 2:
                            MostrarPantallaSolicitarVariosNumeros();
                            Console.WriteLine("Presione una tecla para continuar\n");
                            Console.ReadKey();
                            break;
                        case 3:
                            MostrarPantallaMinimoYMaximo();
                            Console.WriteLine("Presione una tecla para continuar\n");
                            Console.ReadKey();
                            break;
                        case 4:
                            MostrarPantallaPromedio();
                            Console.WriteLine("Presione una tecla para continuar\n");
                            Console.ReadKey();
                            break;
                        case 5:
                            MostrarCantidadDeNumerosIngresados();
                            Console.WriteLine("Presione una tecla para continuar\n");
                            Console.ReadKey();
                            break;
                        case 6:
                            ReiniciarVariables();
                            Console.WriteLine("Presione una tecla para continuar\n");
                            Console.ReadKey();
                            break;
                    }
            } while (opcion != -1);


            Console.WriteLine("Programa Finalizado \n");

        }
    }
}
