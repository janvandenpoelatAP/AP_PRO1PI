using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboOefeningen
{
    public class VariabelenEnDatatypes
    {
        public static void Optellen()
        {
            Console.WriteLine("Wat is het eerste getal?");
            // langere versie:
            // string eersteGetal = Console.ReadLine();
            // int eersteGetalInt = Convert.ToInt32(eersteGetal);
            // kortere versie:
            int eersteGetal = Convert.ToInt32(Console.ReadLine()); 
            Console.WriteLine("Wat is het tweede getal?");
            int tweedeGetal = Convert.ToInt32(Console.ReadLine()); 
            Console.Write("De som is ");
            Console.Write(eersteGetal + tweedeGetal);
            Console.WriteLine(".");
        }
        public static void VerbruikWagen()
        {
            Console.WriteLine("Geef het aantal liter in de tank voor de rit:"); 
            int aantalLiterVoor = Convert.ToInt32(Console.ReadLine()); 
            Console.WriteLine("Geef het aantal liter in de tank na de rit:"); 
            int aantalLiterNa = Convert.ToInt32(Console.ReadLine()); 
            Console.WriteLine("Geef de kilometerstand voor de rit:"); 
            int kilometersVoor = Convert.ToInt32(Console.ReadLine()); 
            Console.WriteLine("Geef de kilometerstand na de rit:"); 
            int kilometersNa = Convert.ToInt32(Console.ReadLine()); 
            double verbruik = 100.0 * (aantalLiterVoor - aantalLiterNa) / (kilometersNa - kilometersVoor);
            Console.Write("Het verbruik van de auto is ");
            Console.Write(verbruik);
            Console.WriteLine(" liter per 100 km");
        }
        public static void BeetjeWiskunde()
        {
            int resultaatInteger;
            resultaatInteger = -1 + 4 * 6;
            Console.WriteLine(resultaatInteger);
            resultaatInteger = (35 + 5) * 7;
            Console.WriteLine(resultaatInteger);
            resultaatInteger = 14 + -4 * 6 / 11;
            Console.WriteLine(resultaatInteger);
            resultaatInteger = 2 + 15 / 6 * 1 - 7 * 2;
            Console.WriteLine(resultaatInteger);
            float resultaatFloat;
            resultaatFloat = -1 + 4 * 6F;
            Console.WriteLine(resultaatFloat);
            resultaatFloat = (35 + 5) * 7F;
            Console.WriteLine(resultaatFloat);
            resultaatFloat = 14 + -4 * 6 / 11F;
            Console.WriteLine(resultaatFloat);
            resultaatFloat = 2 + 15 / 6F * 1 - 7 * 2;
            Console.WriteLine(resultaatFloat);
        }
        public static void Maaltafels()
        {
            int basisGetal = 250;
            Console.Write("1 * ");
            Console.Write(basisGetal);
            Console.Write(" is ");
            Console.WriteLine(1 * basisGetal);
            Console.ReadLine();

            Console.Clear();
            Console.Write("2 * ");
            Console.Write(basisGetal);
            Console.Write(" is ");
            Console.WriteLine(2 * basisGetal);
            Console.ReadLine();
            Console.Clear();

            Console.Write("3 * ");
            Console.Write(basisGetal);
            Console.Write(" is ");
            Console.WriteLine(3 * basisGetal);
            Console.ReadLine();
            Console.Clear();
            
            Console.Write("4 * ");
            Console.Write(basisGetal);
            Console.Write(" is ");
            Console.WriteLine(4 * basisGetal);
            Console.ReadLine();
            // enzovoort
        }
        public static void Ruimte()
        {
            double gewicht = 69;
            double mercurius = 0.38;
            double venus = 0.91;
            Console.WriteLine("Op Mercurius voel je je alsof je " + gewicht * mercurius + "kg weegt.");
            Console.WriteLine("Op Venus voel je je alsof je " + gewicht * venus + "kg weegt.");
            // enzovoort
        }

    }
}

