internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Enter your name: ");
        string name = Console.ReadLine();
        Console.WriteLine("Enter your surname: ");
        string surname = Console.ReadLine();
        Console.WriteLine("Enter your phone number: ");
        string phoneNumber = Console.ReadLine();
        Console.WriteLine("Enter your e-mail address: ");
        string email = Console.ReadLine();
        Console.WriteLine("Enter your height in cm: ");
        int height = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter your weight in kg: ");
        double weight = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter your PESEL");
        string pesel = Console.ReadLine();
        Console.WriteLine("Enter your sex [M / F]");
        char sex = char.Parse(Console.ReadLine());
        Console.WriteLine("Are you married? [\"True\" / \"False\"]");
        bool married = bool.Parse(Console.ReadLine());

        Console.WriteLine("Given data:");
        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"Surname: {surname}");
        Console.WriteLine($"Phone: {phoneNumber}");
        Console.WriteLine($"E-mail: {email}");
        Console.WriteLine($"Height: {height}");
        Console.WriteLine($"Weight: {weight}");
        Console.WriteLine($"PESEL: {pesel}");
        Console.WriteLine($"Sex: {sex}");
        Console.WriteLine($"Married?: {married}");
    }
}