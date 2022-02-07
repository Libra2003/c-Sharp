using System;

namespace Operator
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10, y = 12;
            string a = "abcd", b = "efgh";

            Console.WriteLine("-------Basic Math--------");
            Console.WriteLine((x / y) * x);
            Console.WriteLine(a + b);

            Console.WriteLine("-------Increement--------");
            y++;
            y--;
            Console.WriteLine("----Logical Operator-----");
            Console.WriteLine(x > y && y > 5);
            Console.WriteLine(x > y || y > 5);

            string str = null;
          
            Console.WriteLine(str ?? "Unkonwn value");
            //if(variable is null){
            //varaible = somevalue

            //}
            str ??= "New string";
            Console.WriteLine(str);
           




        }
    }
}
