namespace exercise4
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Enter year: ");
            int year = int.Parse(Console.ReadLine());

            if (year%4 == 0 && year%100 != 0 || year%400 == 0)
            {
                Console.WriteLine($"Rok {year} jest przestepny");
            }
            else
            {
                Console.WriteLine($"Rok {year} nie jest przestepny");
            }
        }
    }
}
