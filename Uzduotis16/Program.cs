using System;

namespace Lecture2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Loterijos bilieto rezultatas
            Random r = new Random();

            int numeris = r.Next(1, 101);

            switch (numeris)
            {
                case >= 1 and <= 20:
                    Console.WriteLine($"Numeris {numeris}, laimėta maža premija");
                    break;

                case > 20 and <= 50:
                    Console.WriteLine($"Numeris {numeris}, laimėta vidutinė premija");
                    break;

                case > 50 and <= 90:
                    Console.WriteLine($"Numeris {numeris}, laimėta didelė premija");
                    break;

                case > 90 and <= 100:
                    Console.WriteLine($"Numeris {numeris}, laimėtas \"Jackpot\"");
                    break;
            }
        }
    }
}