namespace exercise2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 0;
            int odd;
            do
            {
                if (number%2 == 0)
                {
                    Console.WriteLine(number);
                }
                number++;
            } while (number < 1001);
        }
    }
}
