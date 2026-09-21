namespace _2._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //r2z3--------------------
            Console.WriteLine("Obliczymy twoja srednia ocen");
            Console.WriteLine("Podaj 1 liczbe: ");
            string One = Console.ReadLine();
            Console.WriteLine("Podaj 2 liczbe: ");
            string Two = Console.ReadLine();
            Console.WriteLine("Podaj 3 liczbe: ");
            string Three = Console.ReadLine();

            double Num1 = double.Parse(One);
            double Num2 = double.Parse(Two);
            double Num3 = double.Parse(Three);

            double Average = (Num1 + Num2 + Num3) / 3;
            Console.WriteLine($"Srednia ocen to {Math.Round(Average, 2)}");
        }
    }
}