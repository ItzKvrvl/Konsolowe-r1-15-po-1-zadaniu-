namespace _6._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj wielkosc tablicy");

            string SizeStr = Console.ReadLine();
            int Size = int.Parse(SizeStr);
            int[] Tab = new int[Size];

            for (int i = 0; i < Size; i++)
            {
                Console.WriteLine($"Podaj {i + 1} wartosc");
                string ValueStr = Console.ReadLine();
                int Value = int.Parse(ValueStr);

                Tab[i] = Value;
            }

            int min = Tab[0];
            int max = Tab[0];
            int MinNumb = 0, MaxNumb = 0;

            for (int i = 1; i < Tab.Length; i++)
            {
                if (Tab[i] < min)
                {
                    min = Tab[i];
                    MinNumb = i + 1;
                }

                if (Tab[i] > max)
                {
                    max = Tab[i];
                    MaxNumb = i + 1;
                }
            }

            Console.WriteLine(value: $"Wartosc najmniejsza: {min}, pozycja  {MinNumb + 1}");
            Console.WriteLine(value: $"Wartosc najwieksza: {max}, pozycja  {MaxNumb}");

            for (int i = 0; i < Tab.Length - 1; i++)
            {
                for (int j = 0; j < Tab.Length - 1 - i; j++)
                {
                    if (Tab[j] < Tab[j + 1])
                    {
                        int tymczasowa = Tab[j];
                        Tab[j] = Tab[j + 1];
                        Tab[j + 1] = tymczasowa;
                    }
                }
            }

            foreach (int element in Tab)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();
        }
    }
}