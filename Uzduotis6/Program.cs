using System;

namespace Lecture2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Patikrink, ar asmens vardas turi daugiau nei 5 simbolius
            Console.WriteLine("Įveskite vardą:");
            string vardas = Console.ReadLine();

            if (vardas.Length > 5)
            {
                Console.WriteLine("Vardas turi daugiau nei 5 simbolius");
            }
            else
            {
                Console.WriteLine("Vardas neturi daugiau nei 5 simbolių");
            }
        }
    }
}