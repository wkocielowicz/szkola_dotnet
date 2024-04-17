namespace exercise8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int mathScore;
            int physicsScore;
            int chemistyScore;

            Console.WriteLine("Podaj wynik z matematyki: ");
            if (int.TryParse(Console.ReadLine(), out mathScore)) ; else { Console.WriteLine("Invalid data. Enter correct value."); return; }
            Console.WriteLine("Podaj wynik z fizyki: ");
            if (int.TryParse(Console.ReadLine(), out physicsScore)) ; else { Console.WriteLine("Invalid data. Enter correct value."); return; }
            Console.WriteLine("Podaj wynik z chemii: ");
            if (int.TryParse(Console.ReadLine(), out chemistyScore)) ; else { Console.WriteLine("Invalid data. Enter correct value."); return; }

            if ((mathScore > 70 && physicsScore > 55 && chemistyScore > 45 && mathScore+physicsScore+chemistyScore > 180) || mathScore+physicsScore > 150 || mathScore+chemistyScore > 180)
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
