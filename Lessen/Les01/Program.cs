using System;

namespace Les01
{
    class Program
    {
        static void Main(string[] args)
        {
            int getal;
            getal = 6;

            int tweedeGetal;
            tweedeGetal = 5;

            if(getal<=tweedeGetal){
                Console.WriteLine("de waarde van het getal is: " + getal + " kleiner dan of gelijk dan " + tweedeGetal);
                getal++;
            } else {
                Console.WriteLine("de waarde van het getal is: " + getal + " groter dan " + tweedeGetal);
                getal++;
            }

            // Switch case
            int caseSwitch = 0;
      
            switch (caseSwitch)
            {
                case 1:
                    Console.WriteLine("Case 1");
                    caseSwitch++;
                    break;
                case 2:
                    Console.WriteLine("Case 2");
                    caseSwitch++;
                    break;
                default:
                    Console.WriteLine("Default case, het nummer is: " + caseSwitch);
                    break;
            }
        }
    }
}
