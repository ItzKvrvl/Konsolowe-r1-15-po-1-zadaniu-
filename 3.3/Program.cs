namespace _3._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //r3z3--------------------
            Console.WriteLine("Sprawdzimy jaka dostales ocene");

            string One;
            int Wynik;
            do
            {
                Console.WriteLine("Podaj wynik w %: ");
                One = Console.ReadLine();
                Wynik = int.Parse(One);
                if (Wynik < 0 || Wynik > 100)
                {
                    Console.WriteLine("Podaj liczbe od 0 do 100!");
                }
            } while (Wynik < 0 || Wynik > 100);


            if (Wynik >= 90 && Wynik <= 100)
            {
                Console.WriteLine("Ocena bardzo dobra!");
            }
            else if (Wynik >= 75 && Wynik <= 89)
            {
                Console.WriteLine("Ocena dobra!");
            }
            else if (Wynik >= 50 && Wynik <= 74)
            {
                Console.WriteLine("Ocena dostateczna");
            }
            else
            {
                Console.WriteLine("Ocena niedostatecna :C");
            }
        }
    }
}