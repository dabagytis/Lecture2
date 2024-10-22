using System;

namespace Lecture2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Random r = new Random();

            int randomSkaicius = r.Next(1, 99);

            Console.WriteLine(randomSkaicius);
        }
    }
}