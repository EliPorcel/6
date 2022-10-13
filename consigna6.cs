using System;

namespace operaciones_menu
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            
            double num1=0;
            double num2=0; 
            double resultado=0;
            String opcion = "";

            Console.ForegroundColor=ConsoleColor.Blue;
            Console.WriteLine("Operaciones con dos números (enteros o decimales)\n");
            Console.ForegroundColor=ConsoleColor.Green;
            Console.WriteLine("\n¡Buenos días! Por favor, oprima una tecla para comenzar\n"); 
            Console.ReadKey();

            Console.Clear();
            Console.ForegroundColor=ConsoleColor.Magenta;
            Console.WriteLine("Ingrese un número, por favor: ");
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese un segundo número, por favor: ");
            num2 = Convert.ToDouble(Console.ReadLine());

            opcion=menu_opciones(); 
            opcion=Console.ReadLine();
            Console.ForegroundColor=ConsoleColor.Blue;

            switch (opcion)
                {
                 case "1":
                    resultado = Suma (num1, num2);
                    Console.WriteLine("El resultados es: {0}", resultado);
                    break;

                case "2":
                    resultado = Resta (num1, num2);
                    Console.WriteLine("El resultados es: {0}", resultado);
                    break;

                case "3":
                    resultado = Multiplicacion (num1, num2);
                    Console.WriteLine("El resultados es: {0}", resultado);
                    break;

                case "4":
                    if (num2==0)
                    {
                    Console.WriteLine("No es posible dividir entre cero");
                    }
                    else
                    {
                    resultado = Division (num1, num2);
                    Console.WriteLine("El resultados es: {0}", resultado);
                    }
                    break;

                default:
                    Console.WriteLine("Opción no válida");
                    break;
                }

                Console.ForegroundColor=ConsoleColor.Magenta;
                Console.WriteLine("\n ¡Gracias por utilizar el programa!");
                Console.ForegroundColor=ConsoleColor.White;
                Console.WriteLine("\n Presione cualquier tecla para finalizar");
                Console.ReadKey();        
        }

        static double Suma (double num1, double num2)
        {
            double resultado = 0;
            resultado = num1+num2;
            return resultado;
        }

        static double Resta (double num1, double num2)
        {
            double resultado = 0;
            resultado = num1-num2;
            return resultado;
        }

        static double Multiplicacion (double num1, double num2)
        {
            double resultado = 0;
            resultado = num1*num2;
            return resultado;
        }

        static double Division (double num1, double num2)
        {
            double resultado = 0;
            resultado = num1/num2;
            return resultado;
        }

        static string menu_opciones()
        {
            Console.ForegroundColor=ConsoleColor.Green;
            Console.WriteLine("\nElija una operación:\n" + 
            "\n1 .- Suma" +
            "\n2 .- Resta" +
            "\n3 .- Multiplición" +
            "\n4 .- División\n");

            string opcion="";
            return opcion;
        }
    }
}