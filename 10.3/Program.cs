namespace _10._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj dowolna liczbe w przedziale 10-99:");

            int Numb;
            do
            {
                Console.WriteLine("Twoja liczba: ");
                string NumbStr = Console.ReadLine();
                bool IsNumb = int.TryParse(NumbStr, out Numb);

                if (IsNumb && Numb <= 99 && Numb >= 10) Console.WriteLine("Podano poprawna liczbe!");
                else Console.WriteLine("Podana wartosc jest niezgodna z zalozeniem!!");
            } while (Numb < 10 || Numb > 99);

            if (Numb % 2 == 0) Console.WriteLine("Liczba jest parzysta");
            else Console.WriteLine("Liczba jest nieparzysta");
        }
    }
}