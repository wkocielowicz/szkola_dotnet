namespace exercise10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] triangle = new int[3];
            Console.WriteLine("Podaj pierwsza liczbe: ");
            if(int.TryParse(Console.ReadLine(), out triangle[0])) ; else { Console.WriteLine("Invalid data. Enter correct value."); return; }
            Console.WriteLine("Podaj druga liczbe: ");
            if (int.TryParse(Console.ReadLine(), out triangle[1])) ; else { Console.WriteLine("Invalid data. Enter correct value."); return; }
            Console.WriteLine("Podaj trzecia liczbe: ");
            if (int.TryParse(Console.ReadLine(), out triangle[2])) ; else { Console.WriteLine("Invalid data. Enter correct value."); return; }

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
