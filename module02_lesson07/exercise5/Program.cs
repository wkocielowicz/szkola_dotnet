namespace exercise5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age;
            Console.WriteLine("Enter your age: ");
            string? input = Console.ReadLine();

            if(int.TryParse(input, out age))
            {
                if (age >= 21) { Console.WriteLine("Mozesz zostać posłem\nMozesz zostac premierem"); }
                if (age >= 30) { Console.WriteLine("Mozesz zostać senatorem"); }
                if (age >= 35) { Console.WriteLine("Mozesz zostać prezydentem"); }
                else
                {
                    Console.WriteLine("Nie masz uprawnionego wieku do zostania poslem lub senatorem lub premierem.");
                }
            }
            else { Console.WriteLine("Invalid input. Enter correct data."); }
        }
    }
}
