using System;

namespace fibbonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Geef het aantal keer in:");
            int aantalKeer;
            aantalKeer = Convert.ToInt32(Console.ReadLine());
            // int aantalKeer = 5;
            int getal1 = 0;
            int getal2 = 1;
            int getal3;

                Console.WriteLine('\n');
            for (int i = 0; i < aantalKeer; i++)
            {
                getal3 = getal1 + getal2;
                Console.WriteLine(getal3+" ");
                getal1 = getal2;
                getal2 = getal3;
            }
        }
    }
}
