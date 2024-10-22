using System;

namespace Lecture2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Patikrink, ar skaičius lyginis ar nelyginis
            Console.WriteLine("Įveskite skaičių:");
            int a = int.Parse(Console.ReadLine());

            if (a % 2 == 0)
            {
                Console.WriteLine($"{a} yra lyginis skaičius");
            }
            else
            {
                Console.WriteLine($"{a} yra nelyginis skaičius");
            }
        }
    }
}