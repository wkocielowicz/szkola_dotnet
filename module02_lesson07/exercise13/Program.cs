namespace exercise13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj pierwsza liczbe: ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj druga liczbe: ");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj numer operacji do wykonania: ");
            Console.WriteLine("    1. Dodawanie");
            Console.WriteLine("    2. Odejmowanie");
            Console.WriteLine("    3. Mnożenie");
            Console.WriteLine("    4. Dzielenie");
            int menu = int.Parse(Console.ReadLine());
            var result = 0.0;

            switch (menu)
            {
                case 1: result = a + b; break;
                case 2: result = a - b; break;
                case 3: result = a * b; break;
                case 4: if (b != 0) result = a / b; break;
                default: Console.WriteLine("Nieprawidlowa wartosc"); break;
            }
            if (b != 0) Console.WriteLine($"Twoj wynik to: {result}");
            else Console.WriteLine("Nie mozna dzielic przez zero");
        }
    }
}
