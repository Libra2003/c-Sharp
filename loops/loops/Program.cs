using System;

namespace loops
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputstr = "";
            Console.WriteLine("While loop");
            while (inputstr != "exit")
            {
                inputstr = Console.ReadLine();
                Console.WriteLine("You enetered {0}", inputstr);
            }

            Console.WriteLine("do-While loop");

            do
            {
                inputstr = Console.ReadLine();
                Console.WriteLine("You enetered {0}", inputstr);

            } while (inputstr !="exit");

            Console.WriteLine();
        }
    }
}
