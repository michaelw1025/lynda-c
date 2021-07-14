using System;

namespace Properties
{
    // Classes have a name, unique within the namespace
    class Book
    {
        // Classes have member variables, or 'fields' to hold data
        private string _name;
        private string _author;
        private int _pagecount;

        // Classes have one or mare constructors
        public Book(string name, string author, int pages) {
            _name = name;
            _author = author;
            _pagecount = pages;

        }

        // Use Properties to implement access to our internal data
        // This is called a Property with a 'backing field'
        public string Name {
            get {
                return _name;
            }
            set {
                _name = value;
            }
        }

        // There is a shorthand way of writing these using the => operator
        // to create 'expression-bodied' properties
        public string Author {
            get => _author;
            set => _author = value;
        }
        public int Pagecount {
            get => _pagecount;
            set => _pagecount = value;
        }

        // You can omit the get or set if you want to prevent
        // modification or reading the value, or if you want to create a 'computed property'
        // from other fields
        public string Description {
            get => $"{Name} by {Author}, {Pagecount} pages";
        }

        // Properties can be auto-generated - if there is no
        // backing field, the property can hold the data
        public string ISBN {
            get; set;
        }
        public decimal Price {
            get; set;
        }


        // Methods are used to operate on the class and data
        // public string GetDescription() {
        //     return $"{_name} by {_author}";
        // }
    }
}