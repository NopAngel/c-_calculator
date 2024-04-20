using System;

namespace CalculadoraBasica
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Mini Calculadora - Eulises Rodríguez"; // Agrega un título a la ventana

            string resp = ""; // Variable para salir de la aplicación

            do
            {
                // Mostramos el menú de selección
                Console.WriteLine("Presione el símbolo para realizar la operación:");
                Console.WriteLine("+ para sumar");
                Console.WriteLine("- para restar");
                Console.WriteLine("* para multiplicar");
                Console.WriteLine("/ para dividir");
                Console.Write("\nElige una opción: ");
                resp = Console.ReadLine();
                string eleccion = Convert.ToString(resp); // Conversión a caracter

                // Ingresamos los valores
                Console.WriteLine("\nIngrese dos números:");
                Console.Write("Valor1: ");
                int valor1 = int.Parse(Console.ReadLine());
                Console.Write("Valor2: ");
                int valor2 = int.Parse(Console.ReadLine());

                // Realizamos la operación según la elección
                switch (eleccion)
                {
                case "+":
                    Console.WriteLine($ "El resultado de la suma es: {valor1 + valor2}");
                    break;
                case "-":
                    Console.WriteLine($ "El resultado de la resta es: {valor1 - valor2}");
                    break;
                case "*":
                    Console.WriteLine($ "El resultado de la multiplicación es: {valor1 * valor2}");
                    break;
                case "/":
                    if (valor2 != 0)
                        Console.WriteLine($ "El resultado de la división es: {valor1 / (double)valor2}");
                    else
                        Console.WriteLine("No se puede dividir entre cero.");
                    break;
                default:
                    Console.WriteLine("Opción no válida.");
                    break;
                }

                Console.Write("\n¿Deseas realizar otra operación? (s/n): ");
                resp = Console.ReadLine();
            } while (resp == "s" || resp == "S");
        }
    }
}
