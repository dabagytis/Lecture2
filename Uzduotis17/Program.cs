using System;

namespace Lecture2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Orų prognozė pagal temperatūrą
            Random r = new Random();

            int tempC = r.Next(-30, 41);

            switch (tempC)
            {
                case < -10:
                    Console.WriteLine($"Tikimasi {tempC} laipsnių C temperatūros, gresia stipri šalna, rekomenduojama rengtis ypač šiltai");
                    break;

                case >= -10 and <= 0:
                    Console.WriteLine($"Tikimasi {tempC} laipsnių C temperatūros, šaltoka, rekomenduojama šiltai rengtis");
                    break;

                case > 0 and <= 15:
                    Console.WriteLine($"Tikimasi {tempC} laipsnių C temperatūros, vėsu, striukė nepamaišytų");
                    break;

                case > 15 and <= 25:
                    Console.WriteLine($"Tikimasi {tempC} laipsnių C temperatūros, šilta, mėgaukitės gyvenimu");
                    break;
                case > 25:
                    Console.WriteLine($"Tikimasi {tempC} laipsnių C temperatūros, karšta, palikite rūbus namie");
                    break;
            }
        }
    }
}