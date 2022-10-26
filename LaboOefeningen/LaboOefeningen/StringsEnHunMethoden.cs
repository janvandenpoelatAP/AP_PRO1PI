using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboOefeningen
{
    public class StringsEnHunMethoden
    {
        public static void Keuzemenu()
        {
            Console.WriteLine("Kies uit volgende methoden door een cijfer te tikken:");
            Console.WriteLine("    1 – VariabelenEnHoofdletters");
            Console.WriteLine("    2 – MaaltafelsStringInterpolatie");
            Console.WriteLine("    3 – RuimteStringInterpolatie");
            Console.WriteLine("    4 – BerekenBtw");
            Console.WriteLine("    5 – LeetSpeak");
            Console.WriteLine("    6 – Instructies");
            Console.WriteLine("    7 – SomVanCijfers");
            Console.WriteLine("    8 – NaamUitMail");
            Console.WriteLine("    9 – EersteLetterEnAchternaam");
            Console.WriteLine("   10 – Toegangscode");

            string keuze = Console.ReadLine();
            Console.Clear();
            if (keuze == "1")
            {
                VariabelenEnHoofdletters();
            }
            else if (keuze == "2")
            {
                MaaltafelsStringInterpolatie();
            }
            else if (keuze == "3")
            {
                RuimteStringInterpolatie();
            }
            else if (keuze == "4")
            {
                BerekenBtw();
            }
            else if (keuze == "5")
            {
                LeetSpeak();
            }
            else if (keuze == "6")
            {
                Instructies();
            }
            else if (keuze == "7")
            {
                SomVanCijfers();
            }
            else if (keuze == "8")
            {
                NaamUitMail();
            }
            else if (keuze == "9")
            {
                EersteLetterEnAchternaam();
            }
            else if (keuze == "10")
            {
                Toegangscode();
            }
            else
            {
                Console.WriteLine("Verkeerde keuze!");
            }
        }
        public static void VariabelenEnHoofdletters()
        {
            System.Console.WriteLine("Welke tekst moet ik omzetten?");
            string ingetypt = Console.ReadLine();
            System.Console.WriteLine(ingetypt.ToUpper());
        }

        public static void MaaltafelsStringInterpolatie()
        {
            int basisGetal = 250;
            Console.WriteLine($"1 * {basisGetal} is {1 * basisGetal}");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine($"2 * {basisGetal} is {2 * basisGetal}");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine($"3 * {basisGetal} is {3 * basisGetal}");
            Console.ReadLine();
            Console.Clear();
        }

        public static void RuimteStringInterpolatie()
        {
            double gewicht = 69;
            double mercurius = 0.38;
            double venus = 0.91;
            Console.WriteLine($"Op mercurius voel je je alsof je {gewicht * mercurius} kg weegt.");
            Console.WriteLine($"Op venus voel je je alsof je {gewicht * venus} kg weegt.");
        }

        public static void BerekenBtw()
        {
            Console.Write("Geef het bedrag in: ");
            string bedragAlsTekst = Console.ReadLine();
            double bedrag = Convert.ToDouble(bedragAlsTekst);
            // twee regels in één:
            // double bedrag = Convert.ToDouble(Console.ReadLine());
            Console.Write("Geef het BTW-percentage: ");
            double btwPercentage = Convert.ToDouble(Console.ReadLine());
            // langere notatie:
            double resultaat = bedrag + (bedrag * btwPercentage / 100);
            // kortere notatie:
            // double resultaat = bedrag * (1 + btwPercentage / 100);
            Console.WriteLine($"Het bedrag {bedrag} met {btwPercentage}% BTW bedraagt {resultaat}");
        }

        public static void LeetSpeak()
        {
            Console.WriteLine("Geef je tekst in:");
            string tekst = Console.ReadLine();
            // kortere versie:
            // Console.WriteLine(tekst.Replace("a","@").Replace(" ",""));
            string tekstZonderLetterA = tekst.Replace("a", "@");
            string tekstZonderSpaties = tekstZonderLetterA.Replace(" ", "");
            Console.WriteLine(tekstZonderSpaties);
        }

        public static void Instructies()
        {
            Console.WriteLine("Wat is je naam?");
            string naam = Console.ReadLine();
            Console.WriteLine("Wat is de naam van de cursus?");
            string cursus = Console.ReadLine();
            string afgekort = naam.Substring(0, 3).ToUpper();
            Console.WriteLine($"Maak een map als volgt: /home/{afgekort}/{cursus}");
        }

        public static void Lotto()
        {
            Console.WriteLine("Wat zijn je cijfers?");
            string cijfers = Console.ReadLine();
            Console.WriteLine("Je cijfers zijn:");
            Console.WriteLine(cijfers.Substring(0, 8).Replace(",", "|"));
            Console.WriteLine(cijfers.Substring(9).Replace(",", "|"));
        }

        public static void SomVanCijfers()
        {
            Console.WriteLine("Gelieve een getal van exact vijf cijfers in te geven");
            string getalAlsTekst = Console.ReadLine();
            string eersteSymbool = getalAlsTekst.Substring(0, 1);
            string tweedeSymbool = getalAlsTekst.Substring(1, 1);
            string derdeSymbool = getalAlsTekst.Substring(2, 1);
            string vierdeSymbool = getalAlsTekst.Substring(3, 1);
            string vijfdeSymbool = getalAlsTekst.Substring(4, 1);
            int eersteCijfer = Convert.ToInt32(eersteSymbool);
            int tweedeCijfer = Convert.ToInt32(tweedeSymbool);
            int derdeCijfer = Convert.ToInt32(derdeSymbool);
            int vierdeCijfer = Convert.ToInt32(vierdeSymbool);
            int vijfdeCijfer = Convert.ToInt32(vijfdeSymbool);
            Console.WriteLine($"De som van je cijfers is {eersteCijfer + tweedeCijfer + derdeCijfer + vierdeCijfer + vijfdeCijfer}");
        }

        public static void NaamUitMail()
        {
            Console.Write("Geef je e-mailadres: ");
            string email = Console.ReadLine();
            int plaatsAt = email.IndexOf("@");
            string naam = email.Substring(0, plaatsAt);
            Console.WriteLine($"Je naam uit jouw e-mail is {naam.ToUpper()}");

            //Volgende code is uitbreiding en maakte geen deel uit van de opgave.
            string naamZonderPunt = naam.Replace(";", " ");
            Console.WriteLine($"Je naam uit jouw e-mail is {naamZonderPunt.ToUpper()}");
            Console.WriteLine($"Je naam uit jouw e-mail is {naam.ToUpper().Replace(".", " ")}");
            Console.WriteLine($"Je naam uit jouw e-mail is {email.Substring(0, email.IndexOf("@")).ToUpper().Replace(".", " ")}");
        }

        public static void EersteLetterEnAchternaam()
        {
            Console.Write("Geef je naam: ");
            string naam = Console.ReadLine();
            int plaatsSpatie = naam.IndexOf(" ");
            string eersteLetter = naam.Substring(0, 1);
            string achternaam = naam.Substring(plaatsSpatie + 1);
            Console.WriteLine($"Je eerste letter van je voornaam is: {eersteLetter}.");
            Console.WriteLine($"Je achternaam is: {achternaam}");
        }

        public static void Toegangscode()
        {
            Console.Write("Geef je naam: ");
            string naam = Console.ReadLine();
            Console.Write("Geef je geboortejaar: ");
            string geboortejaar = Console.ReadLine();
            Console.Write("Geef je postcode: ");
            string postcode = Console.ReadLine();
            string wachtwoord = naam.Substring(naam.Length - 1, 1).ToLower();
            wachtwoord = wachtwoord + naam.Substring(naam.Length - 2, 1).ToUpper();
            wachtwoord = wachtwoord + geboortejaar.Substring(3, 1);
            wachtwoord = wachtwoord + Math.Pow(Convert.ToInt32(postcode.Substring(0, 1)), 2);
            Console.WriteLine($"Je wachtwoord is {wachtwoord}");
        }
    }
}
