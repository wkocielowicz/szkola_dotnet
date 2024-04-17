namespace exercise3
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int a;

            Console.WriteLine("Enter integer number: ");
            try
            {
                a = int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {

                Console.WriteLine("Invalid input! Please enter an integer number.");
                return;
            }
            

            if (a < 0)
            {
                Console.WriteLine($"{a} is a negative number");
            }
            else if (a == 0)
            {
                Console.WriteLine($"{a} is zero");
            }
            else
            {
                Console.WriteLine($"{a} is a positive number");
            }
        }
    }
}
