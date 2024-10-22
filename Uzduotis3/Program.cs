using System;

namespace Lecture2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Įvertink dieną pagal savaitės dienos numerį
            Console.WriteLine("Įveskite savaitės dienos numerį (1-7):");
            string a = Console.ReadLine();

            switch (a)
            {
                case "1":
                    Console.WriteLine("Pirmadienis");
                    break;
                case "2":
                    Console.WriteLine("Antradienis");
                    break;
                case "3":
                    Console.WriteLine("Trečiadienis");
                    break;
                case "4":
                    Console.WriteLine("Ketvirtadienis");
                    break;
                case "5":
                    Console.WriteLine("Penktadienis");
                    break;
                case "6":
                    Console.WriteLine("Šestadienis");
                    break;
                case "7":
                    Console.WriteLine("Sekmadienis");
                    break;
                default:
                    Console.WriteLine("Netinkamas skaičius");
                    break;
            }
        }
    }
}