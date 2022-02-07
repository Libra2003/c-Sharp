using System;

namespace Prperties
{
    // access modifiers control how properties and methods are accessed
    class Book
    {
        // classes have instance variables to hold data
        private string _name;
        private string _author;
        private int _pagecount;

        // classes have one or more constructors
        public Book(string name, string author, int pages)
        {
            _name = name;
            _author = author;
            _pagecount = pages;
        }


        // use Properties to implement access to our internal data
        // This is called a Property with a "backing field"
        public string Name
        {
            set
            {
                _name = value;
            }
            get
            {
                return _name;
            }
        }

        // There's a shorthand way of writing these using the => operator
        // to create "expression-bodied" properties
        public string Author
        {
            set => _author = value;
            get => _author;

        }
        public int Page
        {
            set => _pagecount = value;
            get => _pagecount;
        }

        // You can omit the get or set if you want to prevent
        // modification or reading the value, or if you want to create
        // a "computed property" from other fields

        public string Desciption
        {
            get=> $"{Name} by {Author}, {Page} pages";
        }

        // Properties can be auto-generated - if there's no
        // backing field, the property can hold the data
        public string ISBN
        {
            set;get;
        }
        public decimal Price
        {
            set;get;
        }

    }

}
        