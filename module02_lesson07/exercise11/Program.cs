namespace exercise11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ocenaTekst;

            Console.WriteLine("Podaj ocene od 1 do 6:");
            string ocena = Console.ReadLine();

            switch (ocena)
            {
                case "1": ocenaTekst = "Niedostateczny";
                    break;
                case "2": ocenaTekst = "Dopuszczajacy";
                    break;
                case "3": ocenaTekst = "Dostateczny";
                    break;
                case "4": ocenaTekst = "Dobry";
                    break;
                case "5": ocenaTekst = "Bardzo dobry";
                    break;
                case "6": ocenaTekst = "Celujacy";
                    break;
                default:
                    ocenaTekst = "Nieznana";
                    break;
            }
            Console.WriteLine(ocenaTekst);
        }
    }
}
