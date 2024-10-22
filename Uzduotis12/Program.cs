using System;

namespace Lecture2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Patikrink, ar įvestas el. pašto adresas yra tinkamo formato...
            Console.WriteLine("Įveskite el. pašto adresą:");
            string pastas = Console.ReadLine();

            if (pastas.Contains("@") && pastas.Contains("."))
            {
                if (pastas.Contains("@gmail.com") || pastas.Contains("@yahoo.com"))
                {
                    Console.WriteLine("Jūs naudojate populiarų el. pašto tiekėją");
                }
                else
                {
                    Console.WriteLine("Jūs naudojate mažiau žinomą el. pašto tiekėją");
                }
            }
            else
            {
                Console.WriteLine("Tai nėra validus el. pašto adresas");
            }
        }
    }
}