using System;
using System.Collections.Generic;

namespace _13._3
{
    internal class Program
    {
        static List<int> Lista = new List<int>();
        static int Number;
        static string NumberStr;

        public static void Warunek()
        {
            bool sukces = int.TryParse(NumberStr, out Number);

            if (sukces)
            {
                if (Number >= 1 && Number <= 6) Lista.Add(Number);
                else Console.WriteLine("Podana liczba nie miesci sie w zakresie 1-6");
            }

            else
            {
                if (NumberStr == "koniec") return;
                else Console.WriteLine("Wprowadzono niepoprawny znak");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Podawaj mi liczby z zakresu 1-6");

            do
            {
                Console.WriteLine("Twoja liczba: ");
                NumberStr = Console.ReadLine();

                Warunek();
            } while (Number > 1 && Number <= 6 || NumberStr != "koniec");

            Console.WriteLine("Liczba wprowadzonych liczb (poprawnych): " + Lista.Count);

            double Sum = 0;

            foreach (int i in Lista)
            {
                Sum += i;
            }
            Console.WriteLine("srednia liczb to: " + Sum / Lista.Count);
        }
    }
}