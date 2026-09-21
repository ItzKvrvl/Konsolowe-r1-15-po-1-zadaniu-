namespace _7._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> Lista = new List<int>();
            int sum = 0;

            Console.WriteLine("Bedziesz podawal liczby calkowite, a ja wstawie je do listy (0 konczy wczytywanie):");

            while (true)
            {
                Console.Write("Podaj liczbe: ");
                string input = Console.ReadLine();

                if (!int.TryParse(input, out int numb))
                {
                    Console.WriteLine("To nie jest poprawna liczba calkowita! Sprobuj ponownie.");
                    continue;
                }

                if (numb == 0)
                {
                    Console.WriteLine("Wprowadzono 0. Zakonmczono wczytywanie.");
                    break;
                }

                Lista.Add(numb);
            }

            Lista.RemoveAll(x => x < 0); //zamiast fora bo jest wygodniej ze wszystko usuwa z listy co jest mniejsze od 0Console.WriteLine("\nPozostale elementy w liscie:");

            for (int i = 0; i < Lista.Count; i++)
            {
                Console.Write(Lista[i] + " ");
                sum += Lista[i];
            }

            Console.WriteLine();

            Console.WriteLine("Ilosc liczb pozostalych: " + Lista.Count);
            Console.WriteLine("Suma liczb: " + sum);
        }
    }
}