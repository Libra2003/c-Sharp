﻿using System;

namespace Inheritance
{
    // TODO: Declare "Book" as a subclass of Publication
    class Books:Publication {
        private string _author;
    

        // use the base() keyword to initialize the base class
        public Books(string name, string author, int pagecount, decimal price) 
           : base(name, pagecount, price){
                _author = author;
            }
        

        public string Author {
            get => _author;
            set => _author = value;
        }
        
        // TODO: use the override keyword to override a base class method
        public override string getDescription()
        {
            return $"{Name} by {Author}, {PageCount}";
        }
    }
}