using System;

namespace Methoden_Implementieren
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Geben sie ein Wort ein");
            String eingabe_string = Console.ReadLine();
            Console.WriteLine("geben sie eine Zahl ein");
            int eingabe_int = Convert.ToInt32(Console.ReadLine());

            int anzahl = 0;
            anzahl = ausgabeTextMalX(eingabe_string, eingabe_int);
            Console.Write("\nAnzahl der Buchstaben: {0}", anzahl);



        }
        public static int ausgabeTextMalX(string eingabe_string, int eingabe_int)

        {
            System.Console.WriteLine(eingabe_string);
            System.Console.WriteLine(eingabe_int);

            return 0;
        }



    }
}
