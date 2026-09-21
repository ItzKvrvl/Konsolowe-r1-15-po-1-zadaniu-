namespace _4._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj dowolna liczbe");
            string Liczba = Console.ReadLine();
            int n = int.Parse(Liczba);

            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    sum += i;
                }
            }
            Console.WriteLine($"Suma liczb parzystych to {sum}");
        }
    }
}