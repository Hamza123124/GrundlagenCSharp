using System;

namespace Hotelgästeplan
{
    class Program
    {
        static void Main()
        {

           do {
                short[] Zimmernummer = { 45, 23, 3, 32 };
                string[] vorname = { "John", "Paul", "George", "Ringo" };
                string[] Nachname = { "Lennon", "McCartney", "Harrison", "Starr", };
                short[] übernachtung = { 1, 4, 12, 3 };
                double[] rechnungsbetrag = { 82.46, 329.84, 989.52, 247.38 };

                Console.WriteLine("Bitte geben sie den Nachnamen oder die Zimmernummer ein");
                string eingabe_str = Console.ReadLine();
                short eingabe_short;

                bool flag = short.TryParse(eingabe_str, out eingabe_short);
            }
            while
        }

        public static String
        {

        }
    }
}
