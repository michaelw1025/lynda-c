using System;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare variables
            int x=10, y=5;
            string a="abcd", b="efgh";

            // Basic math
            // Console.WriteLine((x/y)*x);
            // Console.WriteLine(a+b);

            // Increment/Decrement
            x++;
            y--;
            // Console.WriteLine(x);
            // Console.WriteLine(y);

            // Shorthand 
            // a = a + b
            // a += b;
            // Console.WriteLine(a);

            // Logical operators
            // && and operator  
            // Console.WriteLine(x > y && y >= 5);

            // || or operator  
            // Console.WriteLine(x > y || y >= 5);

            // null-coalescing operators
            string str = null;
            // The ?? operator uses left operand if not null, or the right one if it is 
            Console.WriteLine(str ?? "unkown");
            // The ??= operator assigns the right operand if the left one is null
            str ??= "New String";
            Console.WriteLine(str);
        }
    }
}
