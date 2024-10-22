using System;
using System.ComponentModel.Design;

namespace Lecture2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Gyvenamųjų patalpų nuomos vertinimas
            Console.WriteLine("Nurodykite ieškomo buto norimą kambarių skaičių:");
            int a = int.Parse(Console.ReadLine());
            
            if (a == 1)
            {
                Console.WriteLine("Nurodykite nuomos kainą (eur):");
                int kaina1 = int.Parse(Console.ReadLine());

                if (kaina1 <= 500)
                {
                    Console.WriteLine("Yra galimybė išsinuomoti butą");
                }
                else
                {
                    Console.WriteLine("Būtas gali būti per brangus");
                }
            }
            else if (a == 2 || a == 3)
            {
                Console.WriteLine("Nurodykite nuomos kainą (eur):");
                int kaina2 = int.Parse(Console.ReadLine());

                if (kaina2 <= 1000)
                {
                    Console.WriteLine("Butas yra prieinamas, tačiau galimi papildomi mokesčiai");
                }
                else
                {
                    Console.WriteLine("Butas jums yra neprieinamas");
                }
            }
            else if (a > 3)
            {
                Console.WriteLine("Jūs norite per daug kambarių, apsiraminkit");
            }
            else
            {
                Console.WriteLine("Nevalidus kambarių skaičius");
            }
        }
    }
}