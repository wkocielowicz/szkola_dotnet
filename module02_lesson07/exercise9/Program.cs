﻿namespace exercise9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the temperature in Celsius degrees: ");
            int temp = int.Parse(Console.ReadLine());

            switch (temp)
            {
                case < 0:
                    Console.WriteLine("Cholernie pizdzi");
                    break;
                case <= 10:
                    Console.WriteLine("Zimno");
                    break;
                case < 20:
                    Console.WriteLine("Chlodno");
                    break;
                case < 30:
                    Console.WriteLine("W sam raz");
                    break;
                case < 40:
                    Console.WriteLine("Zaczyna byc slabo, bo goraco");
                    break;
                default:
                    Console.WriteLine("A wez wyprowadzam sie na Alaske");
                    break;
            }
        }
    }
}
