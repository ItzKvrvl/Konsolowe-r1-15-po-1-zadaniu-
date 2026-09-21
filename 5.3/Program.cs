namespace _5._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sekret = 55;
            int liczbaProb = 0;
            int zgadnietaLiczba;

            Console.WriteLine("Zgadnij liczbe.");
            Console.WriteLine("Wybrano wartosc od 1 do 100.");

            do
            {
                Console.Write("Podaj swoja liczbe: ");
                string proba = Console.ReadLine();
                zgadnietaLiczba = int.Parse(proba);

                liczbaProb++;

                if (zgadnietaLiczba < sekret)
                {
                    Console.WriteLine("Za malo. Sprobuj wiekszej liczby.");
                }
                else if (zgadnietaLiczba > sekret)
                {
                    Console.WriteLine("Za duzo. Sprobuj mniejszej liczby.");
                }
            } while (zgadnietaLiczba != sekret && liczbaProb < 8);

            if (liczbaProb <= 7)
            {
                Console.WriteLine($"--Trafiles liczbe w {liczbaProb} probach.--");
                Console.WriteLine("Swietny wynik");
            }
            else
            {
                Console.WriteLine($"Niestety sie nie udalo. liczba to {sekret}");
            }
        }
    }
}