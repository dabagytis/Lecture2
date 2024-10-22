using System;

namespace Lecture2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Patikrink, ar vartotojo įvestas skaičius yra teigiamas dviženklis skaičius
            Console.WriteLine("Įveskite skaičių:");
            int skaicius = int.Parse(Console.ReadLine());

            if (skaicius > 9 && skaicius < 100)
            {
                Console.WriteLine($"{skaicius} yra teigiamas dviženklis skaičius");
            }
            else
            {
                Console.WriteLine($"{skaicius} nėra teigiamas dviženklis skaičius");
            }
        }
    }
}