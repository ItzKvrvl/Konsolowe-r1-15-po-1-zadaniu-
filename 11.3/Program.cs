using System;

namespace _11._3
{
    public class KontoBankowe
    {
        private double _saldo;
        public double Saldo
        {
            get { return _saldo; }
            private set { _saldo = value; }
        }

        public KontoBankowe(double saldoPoczatkowe) { _saldo = saldoPoczatkowe; }
        public KontoBankowe() { _saldo = 0; }

        public void Wplac(double kwota)
        {
            if (kwota > 0)
            {
                Console.WriteLine("Podana kwota zostala dodana do konta");
                _saldo += kwota;
            }
            else
            {
                Console.WriteLine("Niepoprawna wartosc! kwota mniejsza / rowna 0 lub niepoprawny znak!");
            }
        }

        public void Wyplac(double kwota)
        {
            if (kwota > 0 && kwota <= _saldo)
            {
                Console.WriteLine("Podana kwota zostala wyplacona z konta");
                _saldo -= kwota;
            }
            else
            {
                Console.WriteLine("Niepoprawna wartosc! Brak srodkow lub kwota mniejsza od 0!");
            }
        }

        public void PokazSaldo()
        {
            Console.WriteLine("aktualny stan konta: " + _saldo + " zl.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Witaj w naszym banku;");

            KontoBankowe konto = new KontoBankowe();

            konto.PokazSaldo();
            konto.Wplac(1000);
            konto.PokazSaldo();
            konto.Wyplac(500);
            konto.PokazSaldo();
            konto.Wyplac(600);
            konto.PokazSaldo();
        }
    }
}
