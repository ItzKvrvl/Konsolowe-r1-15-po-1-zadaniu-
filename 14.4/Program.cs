using System;
using System.IO;

namespace _14._4
{
    internal class Program
    {
        static void FileCreate()
        {
            Random rand = new Random();

            using (StreamWriter pisarz = new StreamWriter("losowe.txt"))
            {
                for (int i = 1; i <= 10; i++)
                {
                    int number = rand.Next(1, 101);
                    pisarz.WriteLine(number);
                }
            }
            Console.WriteLine("Zapisano liczby do pliku losowe.txt");
        }

        static void FileRead()
        {
            string fileName = "losowe.txt";

            if (!File.Exists(fileName))
            {
                Console.WriteLine($"Szukany plik '{fileName}' nie istnieje");
                return;
            }

            try
            {
                int suma = 0;
                int max = int.MinValue;
                int min = int.MaxValue;

                using (StreamReader czytnik = new StreamReader(fileName))
                {
                    string linia;

                    while ((linia = czytnik.ReadLine()) != null)
                    {
                        Console.WriteLine("Odczytano: " + linia);

                        int liczba = int.Parse(linia);
                        suma += liczba;

                        if (liczba < min)
                        {
                            min = liczba;
                        }

                        if (liczba > max)
                        {
                            max = liczba;
                        }
                    }
                }

                Console.WriteLine("\n--- STATYSTYKI ---");
                Console.WriteLine("Suma wszystkich liczb: " + suma);
                Console.WriteLine("Wartosc najmniejsza (Min): " + min);
                Console.WriteLine("Wartosc najwieksza (Max): " + max);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Wystapil blad podczas odczytu pliku: " + ex.Message);
            }
        }

        static void Main(string[] args)
        {
            FileCreate();
            Console.WriteLine();
            FileRead();
        }
    }
}