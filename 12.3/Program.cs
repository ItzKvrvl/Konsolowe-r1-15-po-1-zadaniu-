using System;
using System.Collections.Generic;

namespace _12._3
{
    public abstract class Pracownik
    {
        public string imie { get; set; }

        public abstract double ObliczWynagrodzenie();
    }

    public class PracownikEtatowy : Pracownik
    {
        public double pensjaMiesieczna { get; set; }

        public override double ObliczWynagrodzenie()
        {
            return pensjaMiesieczna;
        }

        public PracownikEtatowy(string imie, double pensjaMiesieczna)
        {
            this.imie = imie;
            this.pensjaMiesieczna = pensjaMiesieczna;
        }
    }

    public class Zleceniobiorca : Pracownik
    {
        public double stawkaGodzinowa { get; set; }
        public int liczbaGodzin { get; set; }

        public override double ObliczWynagrodzenie()
        {
            return stawkaGodzinowa * liczbaGodzin;
        }

        public Zleceniobiorca(string imie, double stawkaGodzinowa, int liczbaGodzin)
        {
            this.imie = imie;
            this.stawkaGodzinowa = stawkaGodzinowa;
            this.liczbaGodzin = liczbaGodzin;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            List<Pracownik> Pracownicy = new List<Pracownik>()
            {
                new Zleceniobiorca("Jan", 30, 150),
                new PracownikEtatowy("Kuba", 4000),
                new PracownikEtatowy("Natalia", 6000),
                new Zleceniobiorca("Ania", 32, 140)
            };

            double SumaWynagrodzen = 0;

            foreach (var pracownik in Pracownicy)
            {
                double wynagrodzenie = pracownik.ObliczWynagrodzenie();

                Console.WriteLine($"Imię: {pracownik.imie,-12} | Wynagrodzenie: {wynagrodzenie:F2} zł");
                SumaWynagrodzen += wynagrodzenie;
            }

            Console.WriteLine("-------------------------------------");
            Console.WriteLine($"Łączna suma wynagrodzeń: {SumaWynagrodzen:F2} zł");
        }
    }
}
