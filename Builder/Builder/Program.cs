using System;
using System.Text;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder("List building.", 200);
            int jumpCount = 10;
            string[] animals = { "goats", "cats", "pigs" };
            // print some basic stats about the StringBuilder
            Console.WriteLine($"Capacity: {sb.Capacity} Length: {sb.Length}");

            // Add some strings to the builder using Append
            sb.AppendLine();
            sb.Append("The quick brown fox ");
            sb.Append("jumps over a lazy dog");

            // AppendLine can append a line ending
            sb.AppendLine();

            // AppendFormat can be used to append formatted strings
            sb.AppendFormat($"He did this {jumpCount} times over ");
            sb.AppendLine();

            // AppendJoin can iterate over a set of values
            sb.Append("He also jumps over ");
            sb.AppendJoin(" , ", animals);

           // Modify the content using Replace
            sb.Replace("Fox", "Cat");

            sb.Insert(0, "This is the ");

            Console.WriteLine($"Capacity: {sb.Capacity} Length: {sb.Length}");

            // Convert to a single string
            Console.WriteLine(sb.ToString());
        }
    }
}
