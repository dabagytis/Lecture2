using System;

namespace Lecture2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Patikrink, ar vartotojo amžius yra tarp 18 ir 30 metų...
            Console.WriteLine("Įveskite savo amžių:");
            int amzius = int.Parse(Console.ReadLine());
            Console.WriteLine("Ar ęsate studentas? (taip/ne)");
            string statusas = Console.ReadLine();

            if (amzius >=18 && amzius <= 30)
            {
                switch (statusas)
                {
                    case "taip":
                        Console.WriteLine("Jūs galite pretenduoti į akademinę paramą");
                        break;
                    case "ne":
                        Console.WriteLine("Jūs galite gauti stipendiją");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Jūs nepatenkate į tinkamą amžiaus kategoriją");
            }
        }
    }
}