using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LaboOefeningen
{
    internal class NumeriekeData
    {
        public static void Keuzemenu()
        {
            Console.WriteLine("Welke oefening kies je?");
            Console.WriteLine("1. Lengte Oppervlakte Volume");
            Console.WriteLine("2. Schaar, Steen, Papier");
            Console.WriteLine("3. TextCell met Random");
            Console.WriteLine("4. TextCell met Kommagetallen");

            int keuze = Convert.ToInt32(Console.ReadLine());
            if (keuze == 1)
            {
                LengteOppervlakteVolume();
            }
            if (keuze == 2)
            {
                SchaarSteenPapier();
            }
            if (keuze == 3)
            {
                TextCellMetRandom.TextCellMetRandomMain();
            }
            if (keuze == 4)
            {
                TextCellMetKomma.TextCellMetKommaMain();
            }
        }
        public static void LengteOppervlakteVolume()
        {
            Console.Write("Hoe lang is de zijde in meter? ");
            double zijde = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"De lengte is {zijde} m");
            Console.WriteLine($"De oppervlake is {Math.Pow(zijde, 2)} m²");
            Console.WriteLine($"Het volume is {Math.Pow(zijde, 3)} m³");
        }
        public static void SchaarSteenPapier()
        {
            int scoreSpeler = 0;
            int scoreComputer = 0;
            int keuzeSpeler = 0;
            int keuzeComputer = 0;
            Random random = new Random();
            while (scoreSpeler < 10 && scoreComputer < 10)
            {
                Console.WriteLine("Maak een keuze");
                Console.WriteLine(" 1 voor schaar");
                Console.WriteLine(" 2 voor steen");
                Console.WriteLine(" 3 voor papier");
                keuzeSpeler = Convert.ToInt32(Console.ReadLine());
                keuzeComputer = random.Next(1, 4);
                if (keuzeComputer == 1)
                {
                    Console.WriteLine("De computer kiest schaar!");
                    if (keuzeSpeler == 1)
                    {
                        Console.WriteLine("Niemand wint deze ronde!");
                    }
                    else if (keuzeSpeler == 2)
                    {
                        Console.WriteLine("Jij wint deze ronde!");
                        scoreSpeler++;
                    }
                    else
                    {
                        Console.WriteLine("De computer wint deze ronde!");
                        scoreComputer++;
                    }
                }
                else if (keuzeComputer == 2)
                {
                    Console.WriteLine("De computer kiest steen!");
                    if (keuzeSpeler == 1)
                    {
                        Console.WriteLine("Jij wint deze ronde!");
                        scoreSpeler++;
                    }
                    else if (keuzeSpeler == 2)
                    {
                        Console.WriteLine("Niemand wint deze ronde!");
                    }
                    else
                    {
                        Console.WriteLine("De computer wint deze ronde!");
                        scoreComputer++;
                    }
                }
                else
                {
                    Console.WriteLine("De computer kiest papier!");
                    if (keuzeSpeler == 1)
                    {
                        Console.WriteLine("Jij wint deze ronde!");
                        scoreSpeler++;
                    }
                    else if (keuzeSpeler == 2)
                    {
                        Console.WriteLine("De computer wint deze ronde!");
                        scoreComputer++;
                    }
                    else
                    {
                        Console.WriteLine("Niemand wint deze ronde!");
                    }
                }
                Console.WriteLine($"Jij hebt {Score(scoreSpeler)}, de computer heeft {Score(scoreComputer)}.");
            }
        }
        public static string Score(int aantalPunten)
        {
            if (aantalPunten == 1)
            {
                return $"{aantalPunten} punt";
            }
            else
            {
                return $"{aantalPunten} punten";
            }
        }
    }
}
