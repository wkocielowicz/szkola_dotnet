namespace exercise5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your age: ");
            int age = int.Parse(Console.ReadLine());

            if (age >= 21) { Console.WriteLine("Mozesz zostać posłem\nMozesz zostac premierem"); }
            if (age >= 30) { Console.WriteLine("Mozesz zostać senatorem"); }
            else { Console.WriteLine("Nie masz uprawnionego wieku do zostania poslem lub senatorem lub premierem."); }
        }
    }
}
