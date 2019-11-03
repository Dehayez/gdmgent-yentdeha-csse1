using System;

namespace opdracht05
{
    class Program
    {
        static int Som(int getal1, int getal2){
            return getal1 + getal2;
        }

        static int Verschil(int getal1, int getal2 = 5){
            return getal1 - getal2;
        }

        static int Quotiënt(int getal1, int getal2){
            return getal1 / getal2;
        }

        static int Product(int getal1, int getal2){
            return getal1 * getal2;
        }

        static int Modulo(int getal1, int getal2){
            return getal1 % getal2;
        }

        static int Verhogen(int getal){
            return ++getal;
        }

        static int Verlagen(int getal){
            return --getal;
        }

        static int WillekeurigGetal1()  
        {  
            Random random = new Random();  
            return random.Next();  
        } 
        static int WillekeurigGetal2(int min, int max)  
        {  
            Random random = new Random();  
            return random.Next(min, max);  
        } 

        // Lotto
        // Euro millions
        // Genereer account
        // IBAN Checker
        // Faculteit en Fibonnaci
        
        static void SchrijfLog(object output) => Console.WriteLine(output.ToString());

        static void Main(string[] args)
        {
            // alle schrijflogs
            SchrijfLog("Som: " + Som(5,6));
            SchrijfLog("Verschil: " + Verschil(8,5));
            SchrijfLog("Quotiënt: " +Quotiënt(8,2));
            SchrijfLog("Product: " + Product(5,3));
            SchrijfLog("Modulo: " + Modulo(9,2));
            SchrijfLog("Verhogen: " + Verhogen(7));
            SchrijfLog("Verlagen: " + Verlagen(8));
            SchrijfLog("Willekeurig getal: " + WillekeurigGetal1());
            SchrijfLog("Willekeurig getal: " + WillekeurigGetal2(0, 80));

        }
    }
}
