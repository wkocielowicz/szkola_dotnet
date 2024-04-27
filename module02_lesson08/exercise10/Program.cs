namespace exercise10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool convert;
            int number1;
            int number2;

            do
            {
                Console.WriteLine("Enter first integer greater than 0: ");
                convert = int.TryParse(Console.ReadLine(), out number1);
                if (convert == false || number1 < 1)
                {
                    Console.WriteLine("Invalid value. Enter correct integer: ");
                }
            }
            while (!convert || number1 < 1);

            do
            {
                Console.WriteLine("Enter second integer greater than 0: ");
                convert = int.TryParse(Console.ReadLine(), out number2);
                if (convert == false || number2 < 1)
                {
                    Console.WriteLine("Invalid value. Enter correct integer: ");
                }
            }
            while (!convert || number2 < 1);

            List<int> devidedFactorsFromNumber1 = DivideIntoFactors(number1);
            List<int> devidedFactorsFromNumber2 = DivideIntoFactors(number2);

            int nww = NWW(devidedFactorsFromNumber1, devidedFactorsFromNumber2);

            Console.WriteLine($"NWW from numbers {number1} and {number2} is {nww}");

        }
        public static List<int> DivideIntoFactors(int number)
        {
            List<int> result = new List<int>();
            List<int> prime = new List<int>();

            //We are creating a list of prime numbers in range 0 - number, ascending
            for (int i = 2; i < number+1; i++)
            {
                for (int j = 2; j <= Math.Floor(Math.Sqrt(i) + 1); j++)
                {
                    if (i % j == 0 && i != j)
                    {
                        break;
                    }
                    else prime.Add(i);
                }
            }

            //Here we will create a list of decomposition of a number into prime factors
            while (number != 1)
            {
                for (int i = 0; i < prime.Count; i++)
                {
                    if (number % prime[i] == 0)
                    {
                        result.Add(prime[i]);
                        number /= prime[i];
                        break;
                    }
                }
            }
            return result;
        }

        public static int NWW(List<int> factors1, List<int> factors2)
        {
            int nww = 1;
            List<int> allFactors = new List<int>();

            foreach (int factor in factors1)
            {
                if (!allFactors.Contains(factor))
                {
                    allFactors.Add(factor);
                }
            }
            foreach (int factor in factors2)
            {
                if(!allFactors.Contains(factor))
                {
                    allFactors.Add(factor);
                }
            }

            int countForFactors1;
            int countForFactors2;

            foreach (int factor in allFactors)
            {
                countForFactors1 = factors1.Count(n => n == factor);
                countForFactors2 = factors2.Count(n => n == factor);
                if (countForFactors1 >= countForFactors2)
                {
                    nww *= factor*countForFactors1;
                }
                else
                {
                    nww *= factor*countForFactors2;
                }
            }
            return nww;
        }
    }
}
