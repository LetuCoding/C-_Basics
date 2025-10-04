// ==========================================
// Script: Program.cs
// Author: LetuCoding
// Created: 04-10-2025
// Last Updated: 04-10-2025
// Description: Calcula el factorial del número que ingresa el usuario
// ==========================================

using System;

namespace MiNamespace
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingresa un número entero: ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int numero) && numero >= 0)
            {
                long resultado = CalculoFactorial(numero);
                Console.WriteLine($"{numero}! = {resultado}");
            }
            else
            {
                Console.WriteLine("Entrada inválida. Ingresa un número entero mayor o igual a 0.");
            }
        }

        // Método que devuelve el factorial de un número
        public static long CalculoFactorial(int n)
        {
            long factorial = 1;
            for (int i = 2; i <= n; i++)
            {
                factorial *= i;
            }
            return factorial;
        }
    }
}
