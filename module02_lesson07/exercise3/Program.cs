namespace exercise3
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Enter integer number: ");
            int a = int.Parse(Console.ReadLine());

            if (a < 0)
            {
                Console.WriteLine($"{a} jest liczba ujemna");
            }
            else
            {
                Console.WriteLine($"{a} jest liczba nieujemna");
            }
        }
    }
}
