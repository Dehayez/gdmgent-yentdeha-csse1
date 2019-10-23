using System;

namespace Opdracht04
{
    class Program
    {
        static void Main(string[] args)
        {

            double rekenmachine(double getal1, double getal2) 
            {
                double optellen = getal1 + getal2;
                double aftrekken = getal1 - getal2;
                double delen = getal1 / getal2;
                double vermenigvuldigen = getal1 * getal2;

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
