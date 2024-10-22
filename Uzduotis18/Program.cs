using System;

namespace Lecture2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Random r = new Random();

            int laikas = r.Next(0, 24);

            switch (laikas)
            {
                case > 18 or <= 6:
                    Console.WriteLine($"Dabartinis laikas yra {laikas}:00. Rekomenduojame vengti kavos arba rinktis kavą be kofeino. Ar gersite kavos?");
                    string kava = Console.ReadLine();

                    if (kava == "taip")
                    {
                        Console.WriteLine("Ar norėtumėte cukraus?");
                        string cukrus1 = Console.ReadLine();

                        if (cukrus1 == "taip")
                        {
                            Console.WriteLine("Štai jūsų kava su cukrumi");
                        }
                        else
                        {
                            Console.WriteLine("Tokia kava šiuo paros metus gali sutrukdyti jūsų miegą, nerekomenduojame");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Šaunu, gi kam ta nemiga");
                    }
                    break;

                case > 6 and <= 10:
                    Console.WriteLine($"Dabartinis laikas yra {laikas}:00. Rekomenduojame stiprią juodą kavą. Ar norėtumėte cukraus?");
                    string cukrus2 = Console.ReadLine();

                    if (cukrus2 == "taip")
                    {
                        Console.WriteLine("Štai jūsų juoda kava su cukrumi");
                    }
                    else
                    {
                        Console.WriteLine("Štai jūsų juoda kava be cukraus");
                    }
                    break;

                case > 10 and <= 14:
                    Console.WriteLine($"Dabartinis laikas yra {laikas}:00. Rekomenduojame latte. Ar norėtumėte cukraus?");
                    string cukrus3 = Console.ReadLine();

                    if (cukrus3 == "taip")
                    {
                        Console.WriteLine("Štai jūsų latte su cukrumi");
                    }
                    else
                    {
                        Console.WriteLine("Štai jūsų latte be cukraus");
                    }
                    break;

                case > 14 and <= 18:
                    Console.WriteLine($"Dabartinis laikas yra {laikas}:00. Rekomenduojame espresso. Ar norėtumėte cukraus?");
                    string cukrus4 = Console.ReadLine();

                    if (cukrus4 == "taip")
                    {
                        Console.WriteLine("Štai jūsų espresso su cukrumi");
                    }
                    else
                    {
                        Console.WriteLine("Štai jūsų espresso be cukraus");
                    }
                    break;
            }
        }
    }
}