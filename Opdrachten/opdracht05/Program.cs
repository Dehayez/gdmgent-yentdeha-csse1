using System;
using System.Threading;

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

        static int WillekeurigGetal()  
        {  
            Random random = new Random();  
            return random.Next();  
        } 
        static int WillekeurigGetal(int min, int max)  
        {  
            Random random = new Random();  
            return random.Next(min, max);
        } 

        static string LottoRooster(){
            int iter = 0;
            int [] myArray = new int [6];
            for (int i = 0; i < 6; i++) 
            {
                int rn = WillekeurigGetal(1,45);
                int pos = Array.IndexOf(myArray, rn);

                while (pos != -1)
                {
                    rn = WillekeurigGetal(1, 45);
                    pos = Array.IndexOf(myArray, rn);
                }
                myArray[iter] = rn;
                iter++;
            }
            string res = ""; 
            foreach (int getal in myArray) // zorgt voor spatie tussen de cijfers
            {
                res+=getal.ToString();
                res+= " ";
            }
            return res;
        }
        
        static void LottoTrekking(){
            int iter = 0;
            int [] myArray = new int [6];
            SchrijfLog("Lottotrekking: ");
            for (int i = 0; i < 6; i++)
            {
                int rn = WillekeurigGetal(1, 45);
                int pos = Array.IndexOf(myArray, rn);
                while (pos != -1)
                {
                    rn = WillekeurigGetal(1,45);
                    pos = Array.IndexOf(myArray, rn);
                }
                myArray[iter] = rn;
                SchrijfLog(rn);
                iter++;
                Thread.Sleep(2000);
            }
        }

        static string EuromillionsRooster(){
            int iter = 0;
            int [] nArray = new int [5];
            int [] sArray = new int [2];
            for (int i = 0; i < 5; i++)
            {
                int rn = WillekeurigGetal(1,50);
                int pos = Array.IndexOf(nArray, rn);
                while (pos != -1)
                {
                    rn = WillekeurigGetal(1,50);
                    pos = Array.IndexOf(nArray, rn);
                }
                nArray[iter] = rn;
                iter++;
            }


            iter = 0;
            for (int i = 0; i < 2; i++)
            {
                int rn = WillekeurigGetal(1,12);
                int pos = Array.IndexOf(sArray, rn);
                while (pos != -1)
                {
                    rn = WillekeurigGetal(1,12);
                    pos = Array.IndexOf(sArray, rn);
                }
                nArray[iter] = rn;
                iter++;
            }
            string res = "";
            foreach (int getal in nArray)
            {
                res+=getal.ToString();
                res+= " ";
            }
            return res;
        }

        static void EuromillionsTrekking(){
            int iter = 0;
            int [] nArray = new int [5];
            int [] sArray = new int [2];
            SchrijfLog("EuromillionsTrekking:");
            SchrijfLog("De getallen zijn: ");
            for (int i = 0; i < 5; i++)
            {
                int rn = WillekeurigGetal(1,50);
                int pos = Array.IndexOf(nArray, rn);
                while (pos != -1)
                {   
                    rn = WillekeurigGetal(1,50);
                    pos = Array.IndexOf(nArray, rn);
                }
                for (int j = 0; j < 15; j++)
                {
                Console.Write(WillekeurigGetal(1,50));
                Thread.Sleep(100);
                Console.Write("\b \b");
                Console.Write("\b \b");
                }
                nArray[iter] = rn;
                SchrijfLog(rn);
                iter++;
                Thread.Sleep(2000);
            }
            iter = 0;
            SchrijfLog("De sterren zijn: ");
            for (int i = 0; i < 2; i++)
            {
                int rn = WillekeurigGetal(1,12);
                int pos = Array.IndexOf(sArray, rn);
                while (pos != -1)
                {   
                    rn = WillekeurigGetal(1,12);
                    pos = Array.IndexOf(sArray, rn);
                }
                for (int j = 0; j < 15; j++)
                {
                Console.Write(WillekeurigGetal(1,12));
                Thread.Sleep(100);
                Console.Write("\b \b");
                Console.Write("\b \b");
                }

                sArray[iter] = rn;
                SchrijfLog(rn);
                iter++;
                Thread.Sleep(2000);
            }
        }

        
        
        // Genereer account
        // IBAN Checker
        // Faculteit en Fibonnaci

        static void SchrijfLog(object output) => Console.WriteLine(output.ToString());

        static void Main(string[] args)
        {
            // alle schrijflogs
            SchrijfLog("Som: " + Som(5,6));
            SchrijfLog("Verschil: " + Verschil(8,5));
            SchrijfLog("Quotiënt: " + Quotiënt(8,2));
            SchrijfLog("Product: " + Product(5,3) + "\n");

            SchrijfLog("Modulo: " + Modulo(9,2));
            SchrijfLog("Verhogen: " + Verhogen(7));
            SchrijfLog("Verlagen: " + Verlagen(8) + "\n");

            SchrijfLog("Willekeurig getal: " + WillekeurigGetal());
            SchrijfLog("Willekeurig getal van 0 tot 80: " + WillekeurigGetal(0, 80) + "\n");

            SchrijfLog("LottoRooster: " + LottoRooster());
            LottoTrekking();
            SchrijfLog("\n");

            SchrijfLog("Euromillions: " + EuromillionsRooster());
            EuromillionsTrekking();

        }
    }
}
