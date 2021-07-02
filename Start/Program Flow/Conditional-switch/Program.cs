using System;

namespace Conditional_switch
{
    class Program
    {
        static void Main(string[] args)
        {
            int theVal = 66;

            // The switch statment
            switch (theVal){
                case 50:
                    Console.WriteLine("theVal is 50");
                    break;
                case 51:
                    Console.WriteLine("theVal is 51");
                    break;
                case 52:
                    Console.WriteLine("theVal is 52");
                    break;
                case 53:
                case 54:
                case 55:
                    Console.WriteLine("theVal is between 53 and 55");
                    break;
                default:
                    Console.WriteLine("theVal is something else");
                    break;
            }
        }
    }
}
