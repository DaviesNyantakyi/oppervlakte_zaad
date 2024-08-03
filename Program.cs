using System;


namespace OppervlakteZaad
{
    

    class Program
    {
        static void Main()
        {
            // Opvragen van gegevens
            decimal lengte, breedte, kgZaad, resultaatOppverlakte, resultaatNodigZaad;
            Console.WriteLine("Dit programma zal het nodige aantal kg zaad berekenen.\n");

            Console.WriteLine("Geef de volgende gegevens in:");
            Console.Write("Lengte veld: ");
            lengte = decimal.Parse(Console.ReadLine());
            Console.Write("Breedte veld: ");
            breedte = decimal.Parse(Console.ReadLine());
            Console.Write("Aantal kg zaad per m2: ");
            kgZaad = decimal.Parse(Console.ReadLine());

            Console.Write("\n");

            // Berekeningen
            resultaatOppverlakte = lengte * breedte;
            resultaatNodigZaad = resultaatOppverlakte * kgZaad;

            // Resulaat weergeven
            Console.WriteLine($"De oppervlakte van het veld is: {resultaatOppverlakte}");
            Console.WriteLine($"Het aantal kg zaad nodig is: {resultaatNodigZaad}");
            Console.ReadLine();



        }
    }
}
