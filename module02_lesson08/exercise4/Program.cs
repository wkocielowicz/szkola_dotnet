namespace exercise3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 0;
            while (number < 1)
            {
                Console.WriteLine("Enter an integer greater than 1:");
                if (int.TryParse(Console.ReadLine(), out number));
                else
                {
                    Console.WriteLine("Invalid value. Enter an integer greater than 1: ");
                }
            }
            int tempNumber = 1;
            int counter = 1;
            Console.WriteLine("This is your pyramid:\n");
            while (tempNumber < number)
            {
                int i = 1;
                while (i < counter+1)
                {
                    Console.Write(tempNumber + " ");
                    tempNumber++;
                    i++;
                    if (tempNumber == number+1)
                    { break; }
                }
                Console.WriteLine();
                counter++;
            }
        }
    }
}
