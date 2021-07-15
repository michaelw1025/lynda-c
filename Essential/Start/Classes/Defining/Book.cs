using System;

namespace Defining
{
    // Classes have a name, unique within the namespace
    public class Book
    {
        // Classes have member variables, or 'fields' to hold data
        string _name;
        string _author;
        int _pagecount;

        // Classes have one or mare constructors
        public Book(string name, string author, int pages) {
            _name = name;
            _author = author;
            _pagecount = pages;

        }

        // Methods are used to operate on the class and data
        public string GetDescription() {
            return $"{_name} by {_author}";
        }
    }
}