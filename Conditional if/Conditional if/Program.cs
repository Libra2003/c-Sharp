using System;

namespace Conditional
{
    class Program
    {
        static void Main(string[] args)
        {
            int val = 5;
            if (val == 5)
            {
                Console.WriteLine("The val is equal to 5");
            }
            else if(val >= 5)
            {
                Console.WriteLine("The val is equal to or greater than 5");
            }
            else
            {
                Console.WriteLine("Val is less than 5");
            }
            Console.WriteLine(val < 5? "Val is smaller than 5" : "Val is greater than 5");
        }
    }
}
