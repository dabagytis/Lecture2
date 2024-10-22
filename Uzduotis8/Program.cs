using System;

namespace Lecture2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Patikrink, ar trys įvesti skaičiai gali sudaryti lygiašonį trikampį.
            Console.WriteLine("Įveskite trikampio šono ilgį");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Įveskite trikampio pagrindo ilgį");
            int b = int.Parse(Console.ReadLine());

            if (a < a + b && b < a + a)
            {
                Console.WriteLine("Šie ilgiai gali sudaryti trikampį");
            }
            else
            {
                Console.WriteLine("Šie ilgiai negali sudaryti trikampio");
            }
        }
    }
}