using System;

namespace Lecture2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Paskolos paraiškos vertinimas
            Console.WriteLine("Pateikite savo metines pajamas (eur):");
            int pajamos = int.Parse(Console.ReadLine());
            Console.WriteLine("Pateikite savo esamų finansinių įsipareigojimų sumą metams (eur):");
            int islaidos = int.Parse(Console.ReadLine());
            Console.WriteLine("Koks jūsų darbo stažas (metais)?");
            int stazas = int.Parse(Console.ReadLine());

            if (pajamos > 25000 && islaidos < pajamos * 0.4)
            {
                if (stazas > 2)
                {
                    Console.WriteLine("Jūs turite gerą galimybę gauti paskolą");
                }
                else
                {
                    Console.WriteLine("Jums reikia didesnės darbo stažuotės paskolai");
                }
            }
            else
            {
                Console.WriteLine("Jūs galite turėti sunkumų norint gauti paskolą");
            }
        }
    }
}