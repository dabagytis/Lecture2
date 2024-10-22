using System;

namespace Lecture2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Patikrink, ar duomenys įvesti teisingai
            Console.WriteLine("Įveskite el. pašto adresą:");
            string pastas = Console.ReadLine();

            if (string.IsNullOrEmpty(pastas))
            {
                Console.WriteLine("Neįvestas el. pašto adresas");
            }
            else if (pastas.Contains("@") && pastas.Contains("."))
            {
                Console.WriteLine("Įvestas validus el. pašto adresas");
            }
            else
            {
                Console.WriteLine("Neįvestas validus el. pašto adresas");
            }
        }
    }
}