namespace exercise11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj ocene od 1 do 6:");
            if (int.TryParse(Console.ReadLine(), out int ocena)) ; else { Console.WriteLine("Invalid data. Enter correct value."); return; }

            string ocenaTekst = ocena switch
            {
                1 => "Niedostateczny",
                2 => "Dopuszczajacy",
                3 => "Dostateczny",
                4 => "Dobry",
                5 => "Bardzo dobry",
                6 => "Celujacy",
                _ => "Nieznana"
            };
            Console.WriteLine(ocenaTekst);
        }
    }
}
