namespace exercise12
{
    internal class Program
    {
        enum Days
        {
            Poniedziałek = 1,
            Wtorek = 2,
            Sroda = 3,
            Czwartek = 4,
            Piatek = 5,
            Sobota = 6,
            Niedziela = 7
        }
        static void Main(string[] args)
        {
            int nr;
            Console.WriteLine("Podaj numer dnia tygodnia");
            if(int.TryParse(Console.ReadLine(), out nr)); else { Console.WriteLine("Invalid data. Enter correct value."); return; }
            Console.WriteLine((Days)(nr));
        }
    }
}
