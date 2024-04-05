namespace exercise12
{
    internal class Program
    {
        enum Days
        {
            Poniedziałek,
            Wtorek,
            Sroda,
            Czwartek,
            Piatek,
            Sobota,
            Niedziela
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj numer dnia tygodnia");
            int nr = int.Parse(Console.ReadLine());
            Console.WriteLine((Days)(nr-1));
        }
    }
}
