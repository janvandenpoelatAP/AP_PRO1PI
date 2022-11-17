using System;

namespace LaboOefeningen
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welke oefening kies je?");
            Console.WriteLine("   1 - Hoofdstuk 1 - Werken met Visual Studio Code");
            Console.WriteLine("   2 - Hoofdstuk 2 - Variabelen en datatypes");
            Console.WriteLine("   3 - Hoofdstuk 3 - Strings en hun methoden");
            Console.WriteLine("   4 - Hoofdstuk 4 - Beslissingen");
            Console.WriteLine("   5 - Hoofdstuk 5 - Loops");
            Console.WriteLine("   6 - Hoofdstuk 6 - Arrays");
            int keuze = Convert.ToInt32(Console.ReadLine());
            if (keuze == 1)
            {
                EenProgrammaSchrijvenInCSharp.Keuzemenu();
            }
            else if (keuze == 2)
            {
                VariabelenEnDatatypes.Keuzemenu();
            }
            else if (keuze == 3)
            {
                StringsEnHunMethoden.Keuzemenu();
            }
            else if (keuze == 4)
            {
                Beslissingen.Keuzemenu();
            }
            else if (keuze == 5)
            {
                Loops.Keuzemenu();
            }
            else if (keuze == 6)
            {
                Arrays.Keuzemenu();
            }
            else
            {
                Console.WriteLine("Ongeldige keuze!");
            }
        }
    }
}