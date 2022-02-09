using System;

namespace GrundlagenCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            double p = 0, k = 0, n = 0, kn = 0, z = 0, kz = 0, b = 0;
            Console.WriteLine("Geben sie ihren Zinnssatz ein :");
            p = Convert.ToDouble(Console.ReadLine());



            Console.WriteLine("Geben sie ihr Kapital ein :");
            k = Convert.ToDouble(Console.ReadLine());
            kn = k;


            Console.WriteLine("Geben sie ihre Anlagedauer an :");
            n = Convert.ToDouble(Console.ReadLine());




            Console.WriteLine($"{"Jahr",4} {"Guthaben",10} {"Zinsen",8} {"K.Zinsen",10} {"Bilanz",8}");
            Console.WriteLine("-------------------------------------------");



            for (double i = 1; i <= n; i++)
            {
                z = kn * (p / 100);
                kz = kz + z;
                b = k + kz;
                Console.WriteLine($"{i,4} {kn,10:F} {z,8:F} {kz,10:F} {b,8:F}");
                kn = kn + z;

            }





        }
    }
}
