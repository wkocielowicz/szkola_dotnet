namespace exercise8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj wynik z matematyki: ");
            int m = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj wynik z fizyki: ");
            int f = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj wynik z chemii: ");
            int c = int.Parse(Console.ReadLine());

            if ((m > 70 && f > 55 && c > 45 && m+f+c > 180) || m+f > 150 || m+c > 180)
            {
                Console.WriteLine("Kandydat dopuszczony jest do rekrutacji.");
            }
            else
            {
                Console.WriteLine("Kandydat nie jest dopuszczony do rekrutacji.");
            }
        }
    }
}
