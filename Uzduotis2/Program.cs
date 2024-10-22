using System;

namespace Lecture2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Įvertink amžių
            Console.WriteLine("Įveskite amžių:");
            int amzius = int.Parse(Console.ReadLine());

            if (amzius < 13)
            {
                Console.WriteLine("Asmuo yra vaikas");
            }
            else if (amzius < 18)
            {
                Console.WriteLine("Asmuo yra paauglys");
            }
            else if (amzius < 65)
            {
                Console.WriteLine("Asmuo yra suaugęs");
            }
            else
            {
                Console.WriteLine("Asmuo yra senjoras");
            }
        }
    }
}