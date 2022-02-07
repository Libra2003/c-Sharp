using System;


namespace VarsAndData
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            int i = 10;
            float f = 2.0f;
            decimal d = 10.0m;
            bool b = true;
            char c = 'c';

            string str1 = "a string";

            var x = 10;
            var y = "Hello";
            int[] vars = new int[5];
            string[] str = { "as", "23" };

            Console.WriteLine("{0},{1},{2},{3},{4},{5},{6},{7}", i, f, d, b, c, str1, x, y, str);
            Console.ReadLine();
            Console.ReadKey();
        }
    }
    }




