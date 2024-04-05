namespace exercise7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj pierwsza liczbe: ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj druga liczbe: ");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj trzecia liczbe: ");
            double c = double.Parse(Console.ReadLine());

            if (a>b && a>c)
            {
                Console.WriteLine($"{a} jest najwieksza z podanych");
            }
            else if (b>a && b>c)
            {
                Console.WriteLine($"{b} jest najwieksza z podanych");
            }
            else
            {
                Console.WriteLine($"{c} jest najwieksza z podanych");
            }
        }
    }
}
