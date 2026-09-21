using System;

namespace _8._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj liczbe zestawow do losowania: ");
            string NumbStr = Console.ReadLine();

            int Numb = int.Parse(NumbStr);
            int[,] Tab = new int[Numb, 6];
            Random generator = new Random();

            for (int j = 0; j < Numb; j++)
            {
                int ile = 0; // ile liczb juz mamy

                while (ile < 6)
                {
                    int kandydat = generator.Next(1, 50);
                    bool jestJuz = false;

                    for (int i = 0; i < ile; i++)
                    {
                        if (Tab[j, i] == kandydat)
                        {
                            jestJuz = true;
                            break;
                        }
                    }

                    if (!jestJuz)
                    {
                        Tab[j, ile] = kandydat;
                        ile++;
                    }
                }
            }

            for (int i = 0; i < Numb; i++)
            {
                Console.WriteLine($"zestaw: {i + 1}");
                for (int j = 0; j < 6; j++)
                {
                    Console.Write(Tab[i, j] + " ");
                }
                Console.WriteLine();
            }

            int[] liczniki = new int[50];
            for (int i = 0; i < Numb; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    int liczba = Tab[i, j];
                    liczniki[liczba]++;
                }
            }

            int najczestszaLiczba = 1;
            int maxWystapien = liczniki[1];

            for (int i = 2; i <= 49; i++)
            {
                if (liczniki[i] > maxWystapien)
                {
                    maxWystapien = liczniki[i];
                    najczestszaLiczba = i;
                }
            }
            Console.WriteLine($"Najczęściej losowana liczba to: {najczestszaLiczba} (wystąpiła {maxWystapien} razy).");
        }
    }
}