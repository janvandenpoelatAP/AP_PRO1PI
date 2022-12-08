using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboOefeningen
{
    public class Methodes
    {
        public static void Keuzemenu()
        {
            Console.WriteLine("Welke oefening kies je?");
            Console.WriteLine("1. ReeksOperaties");
            Console.WriteLine("2. E-mailadresGenerator");
            Console.WriteLine("3. ReeksOperatiesMetReturn");
            int keuze = Convert.ToInt32(Console.ReadLine());
            if (keuze == 1)
            {
                ReeksOperaties();
            }
            if (keuze == 2)
            {
                EmailadresGenerator();
            }
            if (keuze == 3)
            {
                ReeksOperatiesMetReturn();
            }
        }
        public static void ReeksOperaties()
        {
            Console.Write("Geef de diameter van de cirkel: ");
            double diameter = Convert.ToDouble(Console.ReadLine());
            BerekenStraal(diameter);
            BerekenOmtrek(diameter);
            BerekenOppervlakte(diameter);

            Console.WriteLine("Geef twee getallen:");
            double getal1 = Convert.ToInt32(Console.ReadLine());
            double getal2 = Convert.ToInt32(Console.ReadLine());
            double maxNumber = Maximum(getal1, getal2);
            Console.WriteLine($"Het grootste getal van {getal1} en {getal2} is {maxNumber}");

            Console.WriteLine("Geef een geheel getal:");
            double getal = Convert.ToDouble(Console.ReadLine());
            IsEven(getal);
            ToonOnevenGetallen(getal);
        }

        private static void BerekenStraal(double diameter)
        {
            Console.WriteLine($"De straal van de cirkel is {Math.Round(diameter / 2, 3)}");
        }

        private static void BerekenOmtrek(double diameter)
        {
            Console.WriteLine($"De omtrek van de cirkel is {Math.Round(diameter * Math.PI, 3)}");
        }

        private static void BerekenOppervlakte(double diameter)
        {
            Console.WriteLine($"De oppervlakte van de cirkel is {Math.Round((diameter / 2) * (diameter / 2) * Math.PI, 3)}");
        }

        private static double Maximum(double getal1, double getal2)
        {
            if (getal1 >= getal2)
            {
                return getal1;
            }
            else
            {
                return getal2;
            }
        }

        private static void IsEven(double getal)
        {
            if (getal % 2 == 0)
            {
                Console.WriteLine($"{getal} is een even getal");
            }
            else
            {
                Console.WriteLine($"{getal} is een oneven getal");
            }
        }

        private static void ToonOnevenGetallen(double getal)
        {
            Console.WriteLine($"De reeks van oneven getallen van 1 tot {getal} is:");
            for (int i = 1; i <= getal; i++)
            {
                if (i % 2 != 0)
                {
                    Console.Write($"{i} ");
                }
            }
        }

        public static void EmailadresGenerator()
        {
            string student;

            Console.Write("Geef voornaam: ");
            string voornaam = Console.ReadLine();
            Console.Write("Geef achternaam: ");
            string achternaam = Console.ReadLine();
            Console.Write("student (false/true):");
            bool isStudent = Convert.ToBoolean(Console.ReadLine());
            voornaam = StringToLower(voornaam);
            achternaam = StringToLower(achternaam);
            achternaam = StringTrim(achternaam);
            if (isStudent)
            {
                student = ".student";
            }
            else
            {
                student = "";
            }
            Console.WriteLine("email: " + voornaam + "." + achternaam + student + "@ap.be");
            Console.ReadKey();
        }

        public static string StringToLower(string tekst)
        {
            string output = "";

            foreach (char character in tekst)
            {
                if (character >= 'A' && character <= 'Z')
                {
                    output = output + Convert.ToChar(character - 'A' + 'a');
                }
                else
                {
                    output = output + character;
                }
            }
            return output;
        }

        public static string StringTrim(string tekst)
        {
            string output = "";

            foreach (char character in tekst)
            {
                if (character != ' ')
                {
                    output = output + character;
                }
            }
            return output;
        }

        public static void ReeksOperatiesMetReturn()
        {
            Console.Write("Geef de diameter van de cirkel: ");
            double diameter = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"De straal van de cirkel is {BerekenStraalMetReturn(diameter):f3}");
            Console.WriteLine($"De omtrek van de cirkel is {BerekenOmtrekMetReturn(diameter):f3}");
            Console.WriteLine($"De straal van de cirkel is {BerekenOppervlakteMetReturn(diameter):f3}");
            Console.WriteLine("Geef twee getallen: ");
            double getal1 = Convert.ToDouble(Console.ReadLine());
            double getal2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Het grootste getal van {getal1} en {getal2} is {MaximumMetReturn(getal1, getal2)}");
            Console.WriteLine("Geef een geheel getal: ");
            int getal = Convert.ToInt32(Console.ReadLine());
            if (IsEvenMetReturn(getal))
            {
                Console.WriteLine($"Getal {getal} is een even getal");
            }
            else
            {
                Console.WriteLine($"Getal {getal} is een oneven getal");
            }
            Console.WriteLine($"De reeks van oneven getallen van 1 tot {getal} is:");
            ToonOnevenNummersMetReturn(getal);
            Console.ReadKey();
        }
        public static double BerekenStraalMetReturn(double diameter)
        {
            return Math.Round(diameter / 2, 3);

        }
        public static double BerekenOmtrekMetReturn(double diameter)
        {
            return Math.Round(diameter * Math.PI, 3);
        }
        public static double BerekenOppervlakteMetReturn(double diameter)
        {
            return BerekenStraalMetReturn(diameter) * BerekenStraalMetReturn(diameter) * Math.PI;
        }
        public static double MaximumMetReturn(double getal1, double getal2)
        {
            if (getal1 >= getal2)
            {
                return getal1;
            }
            else
            {
                return getal2;
            }
        }
        public static bool IsEvenMetReturn(int getal)
        {
            if (getal % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static string ToonOnevenNummersMetReturn(int n)
        {
            string onevenNummers = string.Empty;
            for (int i = 1; i <= n; i++)
            {
                if (i % 2 != 0)
                {
                    onevenNummers = onevenNummers + $"{i} ";
                }
            }
            return onevenNummers;
        }
    }
}
}
