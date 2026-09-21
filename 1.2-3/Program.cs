namespace _1._2_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //r1z3--------------------
            Console.WriteLine("R1z3");
            Console.WriteLine("Podaj swoje imie: ");
            string User = Console.ReadLine();
            Console.WriteLine("Podaj swoj ulubiony kolor: ");
            string Color = Console.ReadLine();
            Console.WriteLine("Podaj swoje ulubione zwierze: ");
            string Animal = Console.ReadLine();

            Console.WriteLine($"Czesc {User}! Twoj ulubiony kolor to {Color}, a ulubione zwierze to {Animal}. ");
            Console.WriteLine("\nNacisnij dowolny klawisz, aby wrocic do menu...");
            Console.ReadKey();
        }
    }
}