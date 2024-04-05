namespace exercise10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] triangle = new int[3];
            Console.WriteLine("Podaj pierwsza liczbe: ");
            triangle[0] = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj druga liczbe: ");
            triangle[1] = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj trzecia liczbe: ");
            triangle[2] = int.Parse(Console.ReadLine());

            Console.WriteLine("Podane przez ciebie liczby to:");
            Console.WriteLine(string.Join(",", triangle));

            Array.Sort(triangle);

            if (triangle[0] + triangle[1] > triangle[2])
            {
                Console.WriteLine("Mozna zbudowac trojkat.");
            }
            else
            {
                Console.WriteLine("Nie mozna zbudowac trojkata.");
            }
        }
    }
}
