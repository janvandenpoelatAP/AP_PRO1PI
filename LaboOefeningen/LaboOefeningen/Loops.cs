using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboOefeningen
{
    public class Loops
    {
        public static void Keuzemenu()
        {
            Console.WriteLine("Welke oefening kies je?");
            Console.WriteLine("1. CountDown");
            Console.WriteLine("2. Wachtwoord");
            Console.WriteLine("3. Gemiddelde");
            Console.WriteLine("4. Feestje");
            Console.WriteLine("5. AantalDigits");
            Console.WriteLine("6. SomEvenGetallen");
            Console.WriteLine("7. Factoren");
            Console.WriteLine("8. RNATranscriptie");
            Console.WriteLine("9. Boekhouder");
            Console.WriteLine("10. VanMin100Tot100");
            Console.WriteLine("11. EenTafel");
            Console.WriteLine("12. Veelvouden6En8");
            Console.WriteLine("13. PriemChecker");
            Console.WriteLine("14. PriemGenerator");
            int keuze = Convert.ToInt32(Console.ReadLine());
            if (keuze == 1)
            {
                CountDown();
            }
            else if (keuze == 2)
            {
                Wachtwoord();
            }
            else if (keuze == 3)
            {
                Gemiddelde();
            }
            else if (keuze == 4)
            {
                Feestje();
            }
            else if (keuze == 5)
            {
                AantalDigits();
            }
            else if (keuze == 6)
            {
                SomEvenGetallen();
            }
            else if (keuze == 7)
            {
                Factoren();
            }
            else if (keuze == 8)
            {
                RNATranscriptie();
            }
            else if (keuze == 9)
            {
                Boekhouder();
            }
            else if (keuze == 10)
            {
                VanMin100Tot100();
            }
            else if (keuze == 11)
            {
                EenTafel();
            }
            else if (keuze == 12)
            {
                Veelvouden6En8();
            }
            else if (keuze == 13)
            {
                PriemChecker();
            }
            else if (keuze == 14)
            {
                PriemGenerator();
            }
        }

        public static void CountDown()
        {
            Console.WriteLine("De flowchart is gegeven. Je kan deze laten omzetten door Flowgorithm.");
        }
        public static void Wachtwoord()
        {
            Console.WriteLine("De flowchart is gegeven. Je kan deze laten omzetten door Flowgorithm.");
        }
        public static void Gemiddelde()
        {
            double gemiddelde = 0;
            int aantalGetallen = 0;
            int som = 0;
            int getal = 0;
            do
            {
                Console.Write("Geef het volgende getal in (stoppen met 0): ");
                getal = Convert.ToInt32(Console.ReadLine());
                if (getal != 0)
                {
                    som += getal;
                    aantalGetallen++;
                }
            } while (getal != 0);
            if (aantalGetallen > 0)
            {
                gemiddelde = (1.0 * som) / aantalGetallen;
                Console.WriteLine($"Het gemiddelde: {gemiddelde}");
            }
            else
            {
                Console.WriteLine("Geen getal gegeven");
            }
        }
        public static void Feestje()
        {
            int aantalPersonen = 0;
            string personen = "";
            string antwoord;
            do
            {
                Console.Write("Wil je een volgende persoon inschrijven (ja of nee) ");
                antwoord = Console.ReadLine();
                if (antwoord == "ja")
                {
                    Console.Write("Geef de naam: ");
                    string persoon = Console.ReadLine();
                    if (aantalPersonen > 0)
                    {
                        personen += " ";
                    }
                    aantalPersonen++;
                    personen += persoon;
                }
            } while (antwoord != "nee" && aantalPersonen < 20);
            Console.WriteLine($"Lijst van aanwezigen: {personen}");
            Console.WriteLine($"Er zijn {aantalPersonen} personen aanwezig.");
        }
        public static void AantalDigits()
        {
            int aantalDigits = 0;
            int getal = 0;
            Console.Write("Geef een geheel getal in: ");
            getal = Convert.ToInt32(Console.ReadLine());
            do
            {
                getal /= 10;
                aantalDigits++;
            } while (getal != 0);
            if (aantalDigits == 1)
            {
                Console.WriteLine($"Het ingegeven getal bestaat uit {aantalDigits} cijfer");
            }
            else
            {
                Console.WriteLine($"Het ingegeven getal bestaat uit {aantalDigits} cijfers");
            }
        }
        public static void SomEvenGetallen()
        {
            int j, n, som;
            j = 1;
            som = 0;
            Console.Write("geef n in:");
            n = Convert.ToInt32(Console.ReadLine());
            while (j <= n)
            {
                if (j % 2 == 0)
                {
                    som = som + j;
                    Console.WriteLine($"Even getal {j}, de som van de getallen tot nu toe is {som}");
                }
                j++;
            }
        }
        public static void Factoren()
        {
            int getal;
            int deler = 1;
            Console.Write("Geef een getal (groter dan 1): ");
            getal = Convert.ToInt32(Console.ReadLine());
            Console.Write("Factoren zijn: ");
            while (deler <= getal)
            {
                if ((getal % deler) == 0)
                {
                    if (deler == getal)
                    {
                        Console.Write($"{deler}");
                    }
                    else
                    {
                        Console.Write($"{deler}, ");
                    }
                }
                deler++;
            }

        }
        public static void RNATranscriptie()
        {
            string input = "", DNA = "", RNA = "";
            do
            {
                Console.WriteLine("Voer G,C,T of A in");
                input = Console.ReadLine();
                switch (input)
                {
                    case "G":
                        DNA += "G";
                        RNA += "C";
                        break;
                    case "C":
                        DNA += "C";
                        RNA += "G";
                        break;
                    case "T":
                        DNA += "T";
                        RNA += "A";
                        break;
                    case "A":
                        DNA += "A";
                        RNA += "U";
                        break;
                    default:
                        input = "ongeldig"; //wordt genegeerd
                        break;
                }
            } while (input != "");
            Console.WriteLine($"Je resultaat is: {RNA}");
            Console.ReadKey();
        }
        public static void Boekhouder()
        {
            int getal = 0;
            int somPositieveGetallen = 0;
            int somNegatieveGetallen = 0;
            int aantalGetallen = 0;
            while (true)
            {
                Console.Write("Geef een getal: ");
                getal = Convert.ToInt32(Console.ReadLine());
                if (getal >= 0)
                {
                    somPositieveGetallen += getal;
                }
                else
                {
                    somNegatieveGetallen += getal;
                }
                aantalGetallen++;
                Console.WriteLine($"De balens is: {somPositieveGetallen + somNegatieveGetallen}");
                Console.WriteLine($"De som van de positieve getallen is: {somPositieveGetallen}");
                Console.WriteLine($"De som van de negatieve getallen is: {somNegatieveGetallen}");
                Console.WriteLine($"Het gemiddelde is: {(somPositieveGetallen + somNegatieveGetallen) / aantalGetallen}");
            }
        }
        public static void VanMin100Tot100()
        {
            for (int i = -100; i <= 100; i = i + 2)
            {
                Console.WriteLine(i);
            }
        }
        public static void EenTafel()
        {
            Console.WriteLine("Van welk getal wil je de tafel van vermenigvuldiging zien?");
            int getal = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{i}x{getal} = {getal * i}");
            }
        }
        public static void Veelvouden6En8()
        {
            for (int i = 1; i <= 100; i++)
            {
                if ((i % 6 == 0) || (i % 8 == 0))
                {
                    Console.WriteLine(i);
                }
            }
        }
        public static void PriemChecker()
        {
            Console.WriteLine("Geef een getal");
            int input = Convert.ToInt32(Console.ReadLine());
            int delerTeller = 0;
            for (int i = 2; i <= input; i++)
            {
                if (input % i == 0)
                {
                    delerTeller++;
                }
            }
            if (delerTeller == 1)
            {
                Console.WriteLine("Het getal is een priemgetal!");
            }
            else
            {
                Console.WriteLine("Het getal is geen priemgetal!");
            }
        }
        public static void PriemGenerator()
        {
            Console.Write("Priemgetallen van (laagste getal): ");
            int laagsteGetal = Convert.ToInt32(Console.ReadLine());
            Console.Write("tot en met (hoogste getal): ");
            int hoogsteGetal = Convert.ToInt32(Console.ReadLine());
            while (laagsteGetal <= hoogsteGetal)
            {
                int delerTeller = 0;
                for (int i = 2; i <= laagsteGetal; i++)
                {
                    if (laagsteGetal % i == 0)
                    {
                        delerTeller++;
                    }
                }
                if (delerTeller == 1)
                {
                    Console.Write($"{laagsteGetal} ");
                }
                laagsteGetal++;
            }
        }
    }
}
