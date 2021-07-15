using System;

namespace WhileLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputStr = "";

            // Basic while loop executes while the gate condition is true
            // while (inputStr != "exit"){
            //     inputStr = Console.ReadLine();
            //     Console.WriteLine("You entered: {0}", inputStr);
            // }

            // The do-while loop always executes at least one time
            do {
                inputStr = Console.ReadLine();
                Console.WriteLine("You entered: {0}", inputStr);
            }while(inputStr != "exit");
        }
    }
}
