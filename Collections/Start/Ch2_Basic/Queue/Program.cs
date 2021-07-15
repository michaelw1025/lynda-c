using System;
using System.Collections.Generic;

namespace QueueExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an empty Queue that holds strings
            Queue<string> myQ = new Queue<string>();


            // Add items to the end of the queue
            myQ.Enqueue("one");
            myQ.Enqueue("two");
            myQ.Enqueue("three");
            myQ.Enqueue("four");
            myQ.Enqueue("five");


            // use the count property to see how many items there are
            Console.WriteLine($"Item Count: {myQ.Count}");
            Console.WriteLine("------------------------------------------");

            // Queues can be iterated without changing the structure
            foreach(string s in myQ)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine("------------------------------------------");


            // peek at the front of the queue
            string str = myQ.Peek();
            Console.WriteLine($"The first item is {str}");
            Console.WriteLine("------------------------------------------");

            // remove items from the front of the queue
            str = myQ.Dequeue();
            Console.WriteLine($"Dequeued item is {str}");
            str = myQ.Dequeue();
            Console.WriteLine($"Dequeued item is {str}");
            Console.WriteLine($"Item Count: {myQ.Count}");
            Console.WriteLine("------------------------------------------");

            // see if the queue contains an item
            Console.WriteLine($"Queue contains 'one': {myQ.Contains("one")} ");
            Console.WriteLine($"Queue contains 'one': {myQ.Contains("four")} ");
            Console.WriteLine("------------------------------------------");

            // Remove all the items
            myQ.Clear();
            Console.WriteLine($"Item Count: {myQ.Count}");
            Console.WriteLine("------------------------------------------");
        }
    }
}
