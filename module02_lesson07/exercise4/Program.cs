namespace exercise4
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int year;
            Console.WriteLine("Enter year: ");
            string? input = (Console.ReadLine());

            if(int.TryParse(input, out year))
            {
                if (year % 4 == 0 && year % 100 != 0 || year % 400 == 0)
                {
                    Console.WriteLine($"Rok {year} jest przestepny");
                }
                else
                {
                    Console.WriteLine($"Rok {year} nie jest przestepny");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Enter correct data.");
            }
        }
    }
}
