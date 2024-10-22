using System;

namespace Lecture2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Patikrink, ar du įvesti skaičiai sudaro trikampį
            Console.WriteLine("Įveskite pirmajį skaičių:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Įveskite antrajį skaičių:");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Įveskite trečiajį skaičių:");
            int c = int.Parse(Console.ReadLine());

            if (a < b + c && b < a + c && c < a + b)
            {
                Console.WriteLine("Šie skaičiai gali sudaryti trikampį");
            }
            else
            {
                Console.WriteLine("Šie skaičiai negali sudaryti trikampio");
            }
        }
    }
}