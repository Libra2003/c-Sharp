using System;

namespace strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string phase = "Giraaf Academy";
            Console.WriteLine(phase.IndexOf("Academy"));
            Console.WriteLine(Math.Pow(3,2));

            int num = Convert.ToInt32("34");

            Console.WriteLine("Enter a Number");
            int numb1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a Number");
            int numb2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(numb1 + numb2);

            string color, noun, celebrity;

            color = Console.ReadLine();
            Console.WriteLine($"Roses are {color}");

        }
    }
}
