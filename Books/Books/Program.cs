using System;

namespace Books
{
    public class Books
    {
        static void Main(string[] args)
        {
            Book b1 = new Book ( "War and Peace", "Leo Tolstoy", 825 );
            Book b2 = new Book("The Grapes of Wrath", "John StienBack", 464);

            Console.WriteLine(b1.GetDiscription());
            Console.WriteLine(b2.GetDiscription());


        }
    }
}
