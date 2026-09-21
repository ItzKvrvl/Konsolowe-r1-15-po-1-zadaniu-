namespace _15._3
{
    internal class Program
    {
        static public int GetStudentsCount()
        {
            Console.WriteLine("Podaj liczbe uczniow: ");
            string StudentsStr = Console.ReadLine();
            return int.Parse(StudentsStr);
        }

        static public void PointsPerStudent(int[] studentsTab)
        {
            int passed = 0;

            for (int i = 0; i < studentsTab.Length; i++)
            {
                Console.WriteLine("Podaj wynik z tekstu ucznia nr " + (i + 1));
                string PointsStr = Console.ReadLine();
                int Points = int.Parse(PointsStr);
                studentsTab[i] = Points;

                if (Points >= 50)
                {
                    passed++;
                }
            }
            Console.WriteLine("Liczba uczniow ktorzy zaliczyli egzamin: " + passed);
        }

        static public void AverageCalculator(int[] studentsTab)
        {
            double pointsAverage = 0;

            for (int j = 0; j < studentsTab.Length; j++)
            {
                pointsAverage += studentsTab[j];
            }
            Console.WriteLine("Srednia punktow: " + (pointsAverage / studentsTab.Length));
        }
        /* ********************************
        nazwa funkcji: AverageCalculator
        opis: funkcja odpowiada za przeliczenie sredniej punktow uczniow. w petli dodaje wszystkie wyniki a nastepnie dzieli je przez liczbe ucxniow
        parametry: int[] studentsTab
        zwracany typ i opis: zwraca tekst z wyliczona srednia typu double
        autor: Karol Słotwiński
        ******************************** */

        static void Main(string[] args)
        {
            int students = GetStudentsCount();

            int[] studentsTab = new int[students];

            PointsPerStudent(studentsTab);
            AverageCalculator(studentsTab);

        }
    }
}
