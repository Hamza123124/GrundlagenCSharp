using System;

namespace Array_Noten
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 5;
            int summe = 0;


            int[] noten = new int[n];
            for (int i = 0; i < n; i++)

            {
                
                Console.WriteLine($"Geben sie die Noten {i} ein : ");
                noten[i] = Convert.ToInt32(Console.ReadLine());
                summe = summe + noten[i];
                
            }
            Console.WriteLine("Das sind ihre Noten:");
            for (int p = 0; p < noten.Length; p++)
            {  
                Console.WriteLine(noten[p]);
            }

            Console.WriteLine("ihr durchschnitt ist :");
            Console.WriteLine(summe/n);

        }
    }
}
