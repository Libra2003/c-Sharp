using System;

namespace Prperties
{
    class Program
    {
        static void Main(string[] args)
        {
            Book b1 = new Book("War and Peace", "Leo Tolstoy", 825);

            Console.WriteLine(b1.Name);
            Console.WriteLine(b1.Desciption);

            // Set the ISBN and Price properties
            b1.ISBN = "123234435";
            b1.Price = 24.25m;
            Console.WriteLine(b1.ISBN);
            Console.WriteLine(b1.Price);

            //change the name and page count
            b1.Name = "crime and shit";
            b1.Page = 1234;
            Console.WriteLine(b1.Name);
            Console.WriteLine(b1.Page);
        }
    }
}
