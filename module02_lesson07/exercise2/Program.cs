internal class Program
{
    private static void Main(string[] args)
    {
        int number;
        Console.WriteLine("Enter integer number: ");
        string? input = Console.ReadLine();
        if (int.TryParse(input, out number))
        {
            if (number % 2 != 0)
            {
                Console.WriteLine($"{number} jest liczba nieparzysta");
            }
            else
            {
                Console.WriteLine($"{number} jest liczba parzysta");
            }
        }
        else
        {
            Console.WriteLine("Invalid input, enter integer number.");
        }
    }
}