namespace exercise6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your height: ");
            int age = int.Parse(Console.ReadLine());

            switch (age) 
            {
                case < 140 : Console.WriteLine("Jestes karakanem");
                    break;
                case < 160 : Console.WriteLine("Jestes karłem");
                    break;
                case < 170 : Console.WriteLine("Jestes niski");
                    break;
                case < 180 : Console.WriteLine("Jestes przecietniacha");
                    break;
                case < 190 : Console.WriteLine("Jestes gosc");
                    break;
                case < 200 : Console.WriteLine("Jestes gigantem");
                    break;
                case < 220 : Console.WriteLine("Powalilo Cie???");
                    break;
                default: Console.WriteLine("To niemozliwe");
                    break;
            }
        }
    }
}
