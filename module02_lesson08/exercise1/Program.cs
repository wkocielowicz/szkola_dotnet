namespace exercise1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countPrime = 99;

            for (int i = 2; i < 101; i++)
            {
                for (int j = 2; j <= Math.Floor(Math.Sqrt(i)+1); j++)
                {
                    if (i%j == 0 && i != j)
                    {
                        countPrime--;
                        Console.WriteLine(i);
                        break;
                    }
                }
            }
            Console.WriteLine($"There is {countPrime} prime numbers in range 0-100.");
        }
    }
}
