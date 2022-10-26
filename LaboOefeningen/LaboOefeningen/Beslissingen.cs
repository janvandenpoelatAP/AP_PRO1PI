using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboOefeningen
{
    public class Beslissingen
    {
        public static void Keuzemenu()
        {
            Console.WriteLine("Kies uit volgende methoden door een cijfer te tikken:");
            Console.WriteLine("    1 – Schoenverkoper");
            Console.WriteLine("    2 – EvenOneven");
            Console.WriteLine("    3 – PositiefNegatiefNul");
            Console.WriteLine("    4 – BMIBerekenaar");
            Console.WriteLine("    5 – GrootsteVanDrie");
            Console.WriteLine("    6 – Examen");
            Console.WriteLine("    7 – WetVanOhm");

            string keuze = Console.ReadLine();
            Console.Clear();
            if (keuze == "1")
            {
                Schoenverkoper();
            }
            else if (keuze == "2")
            {
                EvenOneven();
            }
            else if (keuze == "3")
            {
                PositiefNegatiefNul();
            }
            else if (keuze == "4")
            {
                BMIBerekenaar();
            }
            else if (keuze == "5")
            {
                GrootsteVanDrie();
            }
            else if (keuze == "6")
            {
                Examen();
            }
            else if (keuze == "7")
            {
                WetVanOhm();
            }
            else
            {
                Console.WriteLine("Verkeerde keuze!");
            }
        }
        public static void Schoenverkoper()
        {
            double prijs = 50;
            int aantal;

            Console.WriteLine("Hoeveel paar schoenen wil je kopen? ");
            aantal = Convert.ToInt32(Console.ReadLine());
            prijs = prijs * aantal;
            if (aantal >= 2)
            {
                prijs = prijs - prijs * 0.1;
            }
            Console.WriteLine($"De prijs voor {aantal} paar schoenen is {prijs}");
        }
        public static void EvenOneven()
        {
            int getal;
            Console.WriteLine("Geef een getal: ");
            getal = Convert.ToInt32(Console.ReadLine());
            if (getal % 2 == 0)
            {
                Console.WriteLine($"Het getal {getal} is even");
            }
            else
            {
                Console.WriteLine($"Het getal {getal} is oneven");
            }
        }
        public static void PositiefNegatiefNul()
        {
            int getal;
            Console.WriteLine("Geef een getal: ");
            getal = Convert.ToInt32(Console.ReadLine());
            if (getal % 2 == 0)
            {
                if (getal == 0)
                {
                    Console.WriteLine($"Het getal {getal} is nul");
                }
                else
                {
                    Console.WriteLine($"Het getal {getal} is even");
                }
            }
            else
            {
                Console.WriteLine($"Het getal {getal} is oneven");
            }
        }
        public static void BMIBerekenaar()
        {
            Console.WriteLine("Hoe veel weeg je in kg?");
            double mass = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Hoe groot ben je in m ?");
            double length = Convert.ToDouble(Console.ReadLine());

            double bMI = mass / Math.Pow(length, 2);

            Console.WriteLine($"Je BMI bedraagt {bMI:F2}.");

            if (bMI < 18.5)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("ondergewicht");
            }
            else if (bMI < 25)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("normaal gewicht");
            }
            else if (bMI < 30)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("overgewicht");
            }
            else if (bMI < 40)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("zwaarlijvig");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("ernstige obesitas");
            }
        }
        public static void GrootsteVanDrie()
        {
            Console.Write("Geef het eerste getal in: ");
            int getal1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Geef het tweede getal in: ");
            int getal2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Geef het derde getal in: ");
            int getal3 = Convert.ToInt32(Console.ReadLine());
            if (getal1 > getal2 && getal1 > getal3)
            {
                Console.WriteLine($"Het eerste getal ({getal1}) is het grootste");
            }
            else if (getal2 > getal1 && getal2 > getal3)
            {
                Console.WriteLine($"Het tweede getal ({getal2}) is het grootste");
            }
            else
            {
                Console.WriteLine($"Het derde getal ({getal3}) is het grootste");
            }
        }
        public static void Examen()
        {
            Console.Write("Geef het resultaat van het eerste examen: ");
            int resultaat1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Geef het resultaat van het tweede examen: ");
            int resultaat2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Geef het resultaat van het tweede examen: ");
            int resultaat3 = Convert.ToInt32(Console.ReadLine());
            int aantalOnvoldoendes = 0;
            if (resultaat1 < 50)
            {
                aantalOnvoldoendes++;
            }
            if (resultaat2 < 50)
            {
                aantalOnvoldoendes++;
            }
            if (resultaat3 < 50)
            {
                aantalOnvoldoendes++;
            }
            int gemiddelde = (resultaat1 + resultaat2 + resultaat3) / 3;
            if (aantalOnvoldoendes > 1 || gemiddelde < 50)
            {
                Console.WriteLine("Je bent niet geslaagd!");
            }
            else
            {
                Console.WriteLine("Je bent geslaagd!");
            }
        }
        public static void WetVanOhm()
        {
            Console.WriteLine("Wat wil je berekenen? spanning, weerstand of stroomsterkte?");
            string choice = Console.ReadLine();
            if (choice == "spanning")
            {
                Console.WriteLine("Wat is de weerstand?");
                double resistance = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Wat is de stroomsterkte?");
                double current = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine($"De spanning bedraagt {resistance * current}");
            }
            else if (choice == "weerstand")
            {
                Console.WriteLine("Wat is de spanning?");
                double voltage = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Wat is de stroomsterkte?");
                double current = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine($"De spanning bedraagt {voltage / current}");
            }
            else if (choice == "stroomsterkte")
            {
                Console.WriteLine("Wat is de spanning?");
                double voltage = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Wat is de weerstand?");
                double resistance = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine($"De spanning bedraagt {voltage / resistance}");
            }
        }
    }
}
