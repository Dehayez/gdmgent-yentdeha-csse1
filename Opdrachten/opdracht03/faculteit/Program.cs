using System;

namespace faculteit
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Geef een getal in:");
            
            int n_fac = int.Parse(Console.ReadLine());

            for (int i_fac = 0; i_fac < n_fac; i_fac++)  
            {  
            Console.Write(faculteit(i_fac) +" ");  
            } 
          
            Console.Write("\n");
        }

        static int faculteit (int facu){
        int result = facu;
        for(int i = facu-1; i > 1; i--)
        {
           result = result * i;
        }

        return result;
        }
    }
}
