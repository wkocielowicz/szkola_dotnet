namespace exerciese3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int p = 0;
            int q = 1;
            int sum = 0;
            int number = 0;

            while (number < 1)
            {
                Console.WriteLine("Enter how many terms of the Fibonacci sequence you want to see: ");
                if (int.TryParse(Console.ReadLine(), out number));
                else
                {
                    Console.WriteLine("Enter correct value.");
                }
            }

            if (number == 1)
            {
                Console.WriteLine("0");
            }
            else if (number == 2)
            {
                Console.WriteLine("0 1 ");
            }
            else
            {
                Console.Write("0 1 ");
                for (int i = 2; i < number; i++)
                {
                    sum = p + q;
                    Console.Write(sum + " ");
                    p = q;
                    q = sum;
                }
            }  
        }
    }
}
