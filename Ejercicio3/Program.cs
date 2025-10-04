// ==========================================
// Script: Program.cs
// Author: LetuCoding
// Created: 04-10-2025
// Last Updated: 04-10-2025
// description: Este ejercicio trata de pedir al usuario un número entero y determinar si este es par o impar mostrando el resultado en consola
// ==========================================

using System;

namespace MiNamespace
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = Convert.ToInt32(Console.ReadLine());

           if (numero % 2 == 0)
            Console.WriteLine("Par");
           else
            Console.WriteLine("Impar");

        }
    }
}