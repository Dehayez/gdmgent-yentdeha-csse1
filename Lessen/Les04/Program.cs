using System;

namespace Les04
{
    class Program
    {
        static void Main(string[] args)
        {

            double fahr2 = 100;
            double cels2 = (fahr2 - 32) * (5.0/9.0);
            Console.WriteLine(cels2);

            bool test = true;
            Console.WriteLine(test);

            Console.WriteLine(sizeof(System.Boolean).ToString());
            Console.WriteLine(sizeof(System.Int32).ToString());
            Console.WriteLine(sizeof(System.Int64).ToString());
            Console.WriteLine(System.Runtime.InteropServices.Marshal.SizeOf(new System.Boolean()));

            char a = 'c';
            a = 'b';
            // Deze regeel wijzigt de waarde van de variabele a naar de letter b.

            string mijnString = "Dit is mijn eerste regel tekst...";
            Console.WriteLine(mijnString);
            string mijnString2 = "Dit is mijn eerste\nregel tekst";
            Console.WriteLine(mijnString2);

            //Declareer en initialiseer een string
            string mijnString3 = "hallo";
            string mijnString4 = "iedereen";
            //Samenvoegen van de string met een spatie tussen...
            string mijnString5 = mijnString3 + " " + mijnString4;

            Console.WriteLine(mijnString5);

            const double interest = 0.80;

            // Voorbeelden met decimale waarden
            


        }
    }
}
