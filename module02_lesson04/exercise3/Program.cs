internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Enter side a: ");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter side b:");
        int b = int.Parse(Console.ReadLine());

        double c = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
        Console.WriteLine($"Diagonal of rectangle is: {c}");
    }
}