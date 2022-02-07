using System;

namespace String_operations
{
    class Program
    {
        static void Main(string[] args)
        {
            string outstr;
            string str1 = "ab";
            string[] str2 = {"c","d","e", "f","G" };
            //-----------------------------
            Console.WriteLine("Concatinaot");
            outstr = string.Concat(str2);
            Console.WriteLine(outstr);

            Console.WriteLine("join!");
            outstr = string.Join("--",str2);
            Console.WriteLine(outstr);

            // String Comparison
            // Compare will perform an ordinal comparison and return:
            // < 0 : first string comes before second in sort order
            // 0 : first and second strings are same position in sort order
            // > 0 : first string comes after the second in sort order
            Console.WriteLine("Compare");
            int result = String.Compare(str1, "This is the way");
            Console.WriteLine("{0}",result);
        }
    }
}
