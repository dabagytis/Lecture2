using System;

namespace Lecture2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Patikrink, ar įvestas simbolis yra balsė ar priebalsė
            Console.WriteLine("Įveskite raidę:");
            string raide = Console.ReadLine();

            if (raide == "a" || raide == "e" || raide == "i" || raide == "o" || raide == "u")
            {
                Console.WriteLine($"Raidė {raide} yra balsė");
            }
            else
            {
                Console.WriteLine($"Raidė {raide} yra priebalsė");
            }
        }
    }
}