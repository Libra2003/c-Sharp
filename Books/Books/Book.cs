using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books
{
    public class Book
    {
        string _name;
        string _authar;
        int _pagecount;

        // classes have one or more constructors
        public Book(string name, string authar, int page)
        {
            _name = name;
            _authar = authar;
            _pagecount = page;
        }
        //Methods
        public string GetDiscription()
        {
            return $"{_name} by {_authar}";
        }
    }
}
