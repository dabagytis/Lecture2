using System;

namespace Lecture2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Patikrink, ar vartotojo įvestas skaičius yra lyginis...
            Console.WriteLine("Įveskite skaičių:");
            int a = int.Parse(Console.ReadLine());

            if (a % 2 == 0)
            {
                if (a > 20)
                {
                    if (a % 4 == 0)
                    {
                        Console.WriteLine("Skaičius lyginis ir dalijasi iš 4");
                    }
                }
                else
                {
                    Console.WriteLine("Skaičius lyginis, tačiau nėra didesnis nei 20");
                }
            }
            else
            {
                Console.WriteLine("Skaičius yra nelyginis");
            }
        }
    }
}