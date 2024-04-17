namespace exercise6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double sum = 0;

            for (int i = 1; i < 21; i++)
            {
                sum = sum + 1/ (double)i;
            }
            Console.WriteLine(sum);
        }
    }
}
