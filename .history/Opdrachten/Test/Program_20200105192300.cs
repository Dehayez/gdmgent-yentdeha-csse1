using System;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = new string[3,2] {
							{ "bmw", "430" },
							{ "audi", "K3" },
							{ "mercedes", "LE0" }
						};
						Console.WriteLine(array[2,0]);
        }
    }
}
