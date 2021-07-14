using System;

namespace StringRep
{
    class Book 
    {
        public string Name {get; set;}
        public string Author {get; set;}
        public int PageCount {get;}

        public Book(string name, string author, int pages){
            Name = name;
            Author = author;
            PageCount = pages;
        }

        // The ToString() method generates a string representation of the object
        public override string ToString()
        {
            return $"{Name} by {Author}";
        }

        // ToString() can be overloaded to give different format versions 
        // Notice that this version is Not an override function
        public string ToString(char format) {
            if (format == 'B') {
                return $"{Name}:{Author}";
            }
            if (format == 'F') {
                return $"{Name} by {Author} is {PageCount} pages";
            }
            return ToString();
        }

    }
}