/*Elabore un método Calculadora con las siguientes características:
1. Debe devolver un valor de tipo double
2. Debe solicitar como parámetros el tipo de operación (SUMA, RESTA, MULTIPLICACION, DIVISION), 
dos números para operar
3. Debe usar la estructura de selección switch
4. Debe manejar los errores usando un bloque Try-Catch
5. Las divisiones entre 0 no son permitidas, debe devolver -1 usando un operador ternario 
en estos casos. */

using System.Diagnostics.CodeAnalysis;

namespace CalculadoraParcial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calcular();
            static void Calcular()
            {
                Console.WriteLine("escribir numero que desea operar");
                double num1 = double.Parse(Console.ReadLine());
                double num2 = double.Parse(Console.ReadLine());

                Console.WriteLine("escribir 1 para suma");
                Console.WriteLine("escribir 2 para resta");
                Console.WriteLine("escribir 3 para multiplicación");
                Console.WriteLine("escribir 4 para división");
                Console.WriteLine("salir con 0");
    
                double eleccion = double.Parse(Console.ReadLine());
                {
                    switch (eleccion)
                    {
                        case 0:
                            eleccion = 0;
                            break;

                        case 1: eleccion = 1; 
                            double Suma = num1 + num2;
                            Console.WriteLine("resultado: ");
                            Console.WriteLine(Suma);
                        break;

                        case 2: eleccion = 2;
                            double Resta = num1 - num2;
                            Console.WriteLine("resultado: ");
                            Console.WriteLine(Resta);
                            break;

                        case 3:
                            eleccion = 3;
                            double Multi = num1 * num2;
                            Console.WriteLine("resultado: ");
                            Console.WriteLine(Multi);
                            break;

                        case 4:
                            eleccion = 4;
                            double Division = num1 / num2;
                            Console.WriteLine("resultado: ");
                            Console.WriteLine(Division);
                            break;

                    }

                }
            }
        }
    }
}