// ==========================================
// Script: Program.cs
// Author: LetuCoding
// Created: 04-10-2025
// Last Updated: 04-10-2025
// description: Buscar un número en un array.
// ==========================================

using System;

namespace MiNamespace
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            int numeroUsuario = Convert.ToInt32(Console.ReadLine());
            bool existe = false;

            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] == numeroUsuario)
                {
                    existe = true;
                }
            }

            Console.WriteLine(existe);



        }
        

    
    }
}