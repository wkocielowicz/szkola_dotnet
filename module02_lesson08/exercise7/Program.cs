namespace exercise7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int diagonal = 0;
            
            while (diagonal < 1)
            {
                Console.WriteLine("Give the length of the shorter diagonal of the diamond: ");
                if (int.TryParse(Console.ReadLine(), out diagonal)) ;
                else
                {
                    Console.WriteLine("Enter correct value.");
                }
            }

            decimal diagonalDec = diagonal;
            for (int i = 1; i <= Math.Ceiling(diagonalDec / 2); i++)
            {
                for (int j = 0; j < Math.Ceiling(diagonalDec - i * 2) / 2; j++)
                {
                    Console.Write(' ');
                }
                if (diagonal % 2 == 0)
                {
                    for (int k = 0; k < i * 2; k++)
                    {
                        Console.Write('*');
                    }
                }
                else
                {
                    for (int k = 0; k < i * 2 - 1 ; k++)
                    {
                        Console.Write('*');
                    }
                }
                Console.Write("\r\n");
            }
            for (int i = 1; i < Math.Ceiling(diagonalDec / 2); i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(' ');
                }
                for (int k = 0; k < (diagonalDec - i * 2); k++)
                {
                    Console.Write('*');
                }
                Console.Write("\r\n");
            }
        }
    }
}
