using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboOefeningen
{
    public class Meerdimensionaal
    {
        public static void Keuzemenu()
        {
            Console.WriteLine("Welke oefening kies je?");
            Console.WriteLine("1. Som Nde Rij");
            Console.WriteLine("2. Som Rijen");
            Console.WriteLine("3. Pixels");
            Console.WriteLine("5. Conway's Game Of Life ");
            Console.WriteLine("6. HeatmapPaardensprong");

            int keuze = Convert.ToInt32(Console.ReadLine());
            if (keuze == 1)
            {
                TestSomNdeRij();
            }
            if (keuze == 2)
            {
                SomPerRij();
            }
            if (keuze == 3)
            {
                Pixels();
            }
            if (keuze == 4)
            {
                ConwayGameOfLife.ConwayGameOfLifeMain();
            }
            if (keuze == 5)
            {
                HeatMapPaardensprong.HeatmapPaardensprongMain();
            }
        }
        public static void TestSomNdeRij()
        {
            double[,] numbers = {{4.2, 8.1, 3.3},
                     {2.0, 4.0, 6.0},
                     {3.1,3.2,3.3}};
            Console.WriteLine("Van welke rij wil je de som zien?");
            int row = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(SomNdeRij(numbers, row));
        }
        public static double SomNdeRij(double[,] numbers, int row)
        {
            double sum = 0.0;
            for (int column = 0; column < numbers.GetLength(1); column++)
            {
                sum = sum + numbers[row, column];
            }
            return sum;
        }
        public static void SomPerRij()
        {
            Console.WriteLine("Hoe veel rijen telt je array?");
            int aantalRijen = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hoe veel kolommen telt je array?");
            int aantalKolommen = Convert.ToInt32(Console.ReadLine());
            int[,] getallen = new int[aantalRijen, aantalKolommen];
            for (int rij = 0; rij < getallen.GetLength(0); rij++)
            {
                for (int kolom = 0; kolom < getallen.GetLength(1); kolom++)
                {
                    Console.WriteLine($"Waarde voor rij {rij + 1}, kolom {kolom + 1}:");
                    getallen[rij, kolom] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("Sommen per rij:");
            for (int rij = 0; rij < getallen.GetLength(0); rij++)
            {
                int som = 0;
                for (int kolom = 0; kolom < getallen.GetLength(1); kolom++)
                {
                    som += getallen[rij, kolom];
                }
                Console.WriteLine(som);
            }
        }
        public static void SomPerKolom()
        {
            Console.WriteLine("Hoe veel rijen telt je array?");
            int aantalRijen = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hoe veel kolommen telt je array?");
            int aantalKolommen = Convert.ToInt32(Console.ReadLine());
            int[,] getallen = new int[aantalRijen, aantalKolommen];
            for (int rij = 0; rij < getallen.GetLength(0); rij++)
            {
                for (int kolom = 0; kolom < getallen.GetLength(1); kolom++)
                {
                    Console.WriteLine($"Waarde voor rij {rij + 1}, kolom {kolom + 1}:");
                    getallen[rij, kolom] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("Sommen per kolom:");
            for (int kolom = 0; kolom < getallen.GetLength(1); kolom++)
            {
                int som = 0;
                for (int rij = 0; rij < getallen.GetLength(0); rij++)
                {
                    som += getallen[rij, kolom];
                }
                Console.WriteLine(som);
            }
        }
        public static void Pixels()
        {
            ConsoleColor[] kleuren = (ConsoleColor[])Enum.GetValues(typeof(ConsoleColor));
            Console.WriteLine("Hoe veel rijen telt je canvas?");
            int aantalRijen = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hoe veel kolommen telt je canvas?");
            int aantalKolommen = Convert.ToInt32(Console.ReadLine());
            ConsoleColor[,] canvas = new ConsoleColor[aantalRijen, aantalKolommen];
            int keuze = 0;
            while (keuze != 5)
            {
                Console.WriteLine("Wat wil je doen?");
                Console.WriteLine("1. Een pixel kleuren?");
                Console.WriteLine("2. Afbeelding tonen?");
                Console.WriteLine("3. Roodfiter toepassen?");
                Console.WriteLine("4. Driehoekfiter toepassen?");
                Console.WriteLine("5. Stoppen?");
                keuze = Convert.ToInt32(Console.ReadLine());
                if (keuze == 1)
                {
                    Console.WriteLine("Wat is de rij-index van de pixel (begin van af 0?");
                    int indexX = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Wat is de kolom-index van de pixel (begin van af 0?");
                    int indexY = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Welke kleur wil je gebruiken?");
                    for (int i = 0; i < kleuren.Length; i++)
                    {
                        Console.WriteLine($"{i}: {kleuren[i]}");
                    }
                    canvas[indexX, indexY] = (ConsoleColor)Convert.ToInt32(Console.ReadLine());
                }
                else if (keuze == 2)
                {
                    ShowPixels(canvas);
                }
                else if (keuze == 3)
                {
                    RedFilter(canvas);
                    ShowPixels(canvas);
                }
                else if (keuze == 4)
                {
                    LowerTriangleFilter(canvas);
                    ShowPixels(canvas);
                }
            }
        }
        public static void ShowPixels(ConsoleColor[,] canvas)
        {
            Console.Clear();
            for (int rij = 0; rij < canvas.GetLength(0); rij++)
            {
                for (int kolom = 0; kolom < canvas.GetLength(1); kolom++)
                {
                    Console.BackgroundColor = canvas[rij, kolom];
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
        public static void RedFilter(ConsoleColor[,] canvas)
        {
            for (int rij = 0; rij < canvas.GetLength(0); rij++)
            {
                for (int kolom = 0; kolom < canvas.GetLength(1); kolom++)
                {
                    if ((rij % 2 != 0) && (kolom % 2 != 0))
                    {
                        canvas[rij, kolom] = ConsoleColor.Red;
                    }
                }
            }
        }
        public static void LowerTriangleFilter(ConsoleColor[,] canvas)
        {
            if (canvas.GetLength(0) != canvas.GetLength(1))
            {
                Console.WriteLine("Deze filter kan niet worden toegepast op deze afbeelding");
            }
            else
            {
                for (int rij = 0; rij < canvas.GetLength(0); rij++)
                {
                    for (int kolom = 0; kolom < canvas.GetLength(1); kolom++)
                    {
                        if (kolom > rij)
                        {
                            canvas[rij, kolom] = ConsoleColor.White;
                        }
                    }
                }
            }
        }

    }
}

