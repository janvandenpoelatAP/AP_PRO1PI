using System;

namespace LaboOefeningen
{
    public class EenProgrammaSchrijvenInCSharp
    {
        public static void MijnEersteMethode()
        {
            Console.WriteLine("Mijn eerste methode werkt!");
        }
        public static void MijnEersteProgramma()
        {
            Console.WriteLine("Dit is mijn eerste C#-programma");
            Console.WriteLine("*******************************");
            Console.Write("Typ je naam: ");
            string naam = Console.ReadLine();
            Console.Write("Hallo ");
            Console.WriteLine(naam);
        }

        public static void MijnEersteProgramma_FG()
        {
            string voornaam;
            string achternaam;

            Console.WriteLine("Type je voornaam:");
            voornaam = Console.ReadLine();
            Console.WriteLine("Type je achternaam:");
            achternaam = Console.ReadLine();
            Console.WriteLine("Je naam is dus " + achternaam + " " + voornaam);
            Console.WriteLine("Of " + voornaam + " " + achternaam);
        }

        public static void Rommelzin()
        {
            Console.WriteLine("Wat is je favoriete kleur? ");
            string kleur = Console.ReadLine();
            Console.WriteLine("Wat is je favoriete eten? ");
            string eten = Console.ReadLine();
            Console.WriteLine("Wat is je favoriete auto? ");
            string auto = Console.ReadLine();
            Console.WriteLine("Wat is je favoriete film? ");
            string film = Console.ReadLine();
            Console.WriteLine("Wat is je favoriete boek? ");
            string boek = Console.ReadLine();
            Console.WriteLine("Je favoriete kleur is " + eten + ". Je eet graag " + auto + ".Je lievelingsfilm is " + boek + " en je favoriete boek is " + film);
        }
        public static void GekleurdeRommelzin()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Wat is je favoriete kleur? ");
            Console.ResetColor(); ;
            string kleur = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Wat is je favoriete eten? ");
            Console.ResetColor(); ;
            string eten = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Wat is je favoriete auto? ");
            Console.ResetColor(); ;
            string auto = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Wat is je favoriete film? ");
            Console.ResetColor(); ;
            string film = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Wat is je favoriete boek? ");
            Console.ResetColor(); ;
            string boek = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Je favoriete kleur is " + eten + ". Je eet graag " + auto + ".Je lievelingsfilm is " + boek + " en je favoriete boek is " + film);
            Console.ResetColor(); ;
        }
    }
}
