namespace exercise7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a;
            double b;
            double c;

            Console.WriteLine("Podaj pierwsza liczbe: ");
            if (double.TryParse(Console.ReadLine(), out a)) ;
            else { Console.WriteLine("Invalid data. Enter correct value."); return; }
            Console.WriteLine("Podaj druga liczbe: ");
            if (double.TryParse(Console.ReadLine(), out b)) ;
            else { Console.WriteLine("Invalid data. Enter correct value."); return; }
            Console.WriteLine("Podaj trzecia liczbe: ");
            if (double.TryParse(Console.ReadLine(), out c)) ;
            else { Console.WriteLine("Invalid data. Enter correct value."); return; }

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
