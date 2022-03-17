using System;

namespace Array_Noten
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 5;  //Anzahl Noten
            int summe = 0; 

            int[] noten = new int[n];  //Array für Noten
            for (int i = 0; i < noten.Length ;i++)   //For schleife 

            {
                Console.WriteLine($"Geben sie die {i+1}. Note ein "); //Eingabe aufforderung 
                noten[i] = Convert.ToInt32(Console.ReadLine());   //Einlese innitialisieren der Noten in Array
                summe = summe + noten[i];
            }

            for (int i = 0; i < noten.Length;i++)

            {
                Console.WriteLine("Ihre Noten sind :");
                Console.WriteLine($"{i+1}.Note{noten[i]}");

            }
            Console.WriteLine($"ihr durchschnitt ist {(double) summe / n} ");



        }
    }
}
