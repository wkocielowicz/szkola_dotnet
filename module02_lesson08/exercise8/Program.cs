namespace exercise8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string? text;
            Console.WriteLine("Enter some text: ");
            text = Console.ReadLine();
            int textLength = text.Length;
            for (int i = textLength; i > 0; i--)
            {
                Console.Write(text[i-1]);
            }
        }
    }
}
