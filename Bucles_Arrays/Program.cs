// ==========================================
// Script: Program.cs
// Author: LetuCoding
// Created: 04-10-2025
// Last Updated: 04-10-2025
// description: Varios ejercicios de arrays y bucles
// ==========================================

using System;

namespace MiNamespace
{
    class Program
    {
        static void Main(string[] args)
        {

            //Ejercicio 6
            //Console.WriteLine(ContarVocales("Hola mundo"));

            //Ejercicio7
            /*double[] notas = { 5.0, 6.0, 10.0, 6.0, 0, 2.0 };
            Console.WriteLine(MediaDeNotas(notas));*/

            //EJercicio8
            /*int[] numeros = { 0, 9, 3, 4, 5 };
            Console.WriteLine( Program.numerosMayoresMenores(numeros));
            */
            



        }

        // =============================================================
        // EJERCICIO 6: CONTAR VOCALES EN UNA FRASE
        // =============================================================
        public static int ContarVocales(string oracion)
        {
            int x = 0;
            foreach (char i in oracion.ToLower())
            {
                if (i == 'a' || i == 'e' || i == 'i' || i == 'o' || i == 'u')
                {
                    x++;
                }
            }

            return x;

        }


        // =============================================================
        //  EJERCICIO 7: PROMEDIO DE NOTAS
        // =============================================================
        public static double MediaDeNotas(double[] notas)
        {
            int sumaNotas = 0;

            foreach (int i in notas)
            {
                sumaNotas += i;
            }

            return (sumaNotas / notas.Length);
        }


        // =============================================================
        // EJERCICIO 8: NÚMERO MAYOR Y MENOR
        // =============================================================
        public static string numerosMayoresMenores(int[] numeros)
        {
            int max = numeros[0];
            int min = numeros[0];
            foreach (int i in numeros)
            {

                if (i > max)
                {
                    max = i;
                }


                if (i < min)
                {
                    min = i;
                }

            }

            return ("el numero más grande es: " + max + " " + "El numero más pequeño es: " + min);
        }

        


    }
}