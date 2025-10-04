// ==========================================
// Script: Program.cs
// Author: LetuCoding   
// Created: 04-10-2025
// Last Updated: 04-10-2025
// description: Esta clase va a simular un sistema de inventario básico (POO)
// ==========================================

using System;

namespace Inventario
{
    public class Item
    {
        public int id;
        public string nombre;
        public int cantidad
        {
            get; set;
        }

        public Item(int id, string nombre, int cantidad)
        {
            this.id = id;
            this.nombre = nombre;
            this.cantidad = cantidad;
        }



    }


    public class InventarioPlayer
    {
        List<Item> inventario = new List<Item>();
    }



    class RPG
    {
        public static void Main(string[] args)
        {
            Menu();
        }

        public static void Menu()
        {

            Console.WriteLine("=============== RPG ===============");
            Console.WriteLine("1 - START");
            Console.WriteLine("2 - CLOSE");
            Console.Write("\nEscribe tu elección: ");

            string entrada = Console.ReadLine();
            int eleccion;

            if (int.TryParse(entrada, out eleccion))
            {
                switch (eleccion)
                {
                    case 1:
                        //Start()
                        Console.WriteLine("Starting game...");
                        break;

                    case 2:
                        //Close()
                        Console.WriteLine("Closing game...");
                        break;

                    default:
                        Console.WriteLine("Opción no válida. Intenta nuevamente.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Por favor, ingresa un número válido.");
                Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");
                Menu();
            }
        }



        public static void Start()
        {
            string name;
            int eleccion;
            Console.WriteLine("¿Cuál es tu nombre?");

            name = Console.ReadLine();
            Console.WriteLine($"Tu nombre es: {name}");


            Console.WriteLine("¿Qué quieres hacer?");





        }
    }
    
    
    

}