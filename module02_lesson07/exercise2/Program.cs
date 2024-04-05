internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Enter integer number: ");
        int a = int.Parse(Console.ReadLine());

        if (a%2 != 0)
        {
            Console.WriteLine($"{a} jest liczba nieparzysta");
        }
        else
        {
            Console.WriteLine($"{a} jest liczba parzysta");
        }
    }
}