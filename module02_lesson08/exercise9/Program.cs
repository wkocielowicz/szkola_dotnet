using System.Numerics;
using System.Security.Cryptography.X509Certificates;

namespace exercise9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int decimalNumber;
            bool convert;
            int[] binaryNumber;

            do
            {
                Console.WriteLine("Enter an integer: ");
                convert = int.TryParse(Console.ReadLine(), out decimalNumber);
                if (convert == false)
                {
                    Console.WriteLine("Invalid value. Enter correct integer: ");
                }
            }
            while (!convert);

            if (decimalNumber < 0)
            {
                decimalNumber = -decimalNumber;
                binaryNumber = DecToBinary(decimalNumber);
                
                Console.Write($"binary: -");
                foreach (int numb in binaryNumber)
                {
                    Console.Write(numb);
                }
            }
            else if (decimalNumber == 0)
            {
                Console.Write($"binary: 0");
            }
            else
            {
                binaryNumber = DecToBinary(decimalNumber);

                Console.Write($"binary: ");
                foreach (int numb in binaryNumber)
                {
                    Console.Write(numb);
                }
            }
        }
        public static int[] DecToBinary(int decimalNumber)
        {
            List<int> binaryNumberPositions = [];
            int tempPower = 0;
            int position = 0;

            while (decimalNumber > 0)
            {
                //We check what maximum power of the number 2 will fit in our number.
                while (Math.Pow(2, tempPower) <= decimalNumber)
                {
                    position = tempPower;
                    tempPower++;
                }
                //We will record this power in our item list. This item will have a value of 1 in the binary number.
                binaryNumberPositions.Add(position);
                decimalNumber -= (int)Math.Pow(2, tempPower - 1);
                tempPower = 0;
            }
            //We check maximum value in positions list. We want to know, how many position will have binary number.
            int maxPosition = binaryNumberPositions.Max();
            int[] binaryNumber = new int[maxPosition + 1];

            /*Now we know how many positions our binary number will have. We'll spell out all the positions - from 0 to 1.
            If, any position is in the "binaryNumberPositions" list, we'll write the number one in that place. If the item
            will not be in our list - then we will type 0 here.*/
            for (int i = 0; i < maxPosition + 1; i++)
            {
                if (binaryNumberPositions.Contains(i))
                {
                    binaryNumber[maxPosition - i] = 1;
                }
                else
                {
                    binaryNumber[maxPosition - i] = 0;
                }
            }
            return binaryNumber;
        }
    }
}