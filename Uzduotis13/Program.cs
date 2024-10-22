using System;

namespace Lecture2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Patikrink, ar vartotojo įvestas skaičius yra teigiamas ir didesnis nei 100...
            Console.WriteLine("Įveskite skaičių");
            int a = int.Parse(Console.ReadLine());

            if (a > 100)
            {
                if (a % 10 == 0)
                {
                    Console.WriteLine($"{a} yra didelis skaičius, kuris dalijasi iš 10");
                }
                else
                {
                    Console.WriteLine($"{a} yra didelis skaičius, tačiau nesidalija iš 10");
                }
            }
            else
            {
                Console.WriteLine($"{a} yra mažesnis skaičius nei 100");
            }
        }
    }
}