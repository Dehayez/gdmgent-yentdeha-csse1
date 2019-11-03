using System;

namespace Opdracht04
{
    class Program
    {
        static void Main(string[] args)
        {

            int rekenmachine(int getal1, int getal2) 
            {
                int optellen = getal1 + getal2;
                int aftrekken = getal1 - getal2;
                int delen = getal1 / getal2;
                int vermenigvuldigen = getal1 * getal2;

                Console.WriteLine(getal1 + " + " + getal2 + " = " + optellen);
                Console.WriteLine(getal1 + " - " + getal2 + " = " + aftrekken);
                Console.WriteLine(getal1 + " * " + getal2 + " = " + vermenigvuldigen);
                Console.WriteLine(getal1 + " / " + getal2 + " = " + delen);

                return optellen + aftrekken + vermenigvuldigen + delen;
            }
                rekenmachine(8, 2);        
        
        }
        
    }
}
