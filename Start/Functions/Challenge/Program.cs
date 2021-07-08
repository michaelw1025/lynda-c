using System;
using System.Linq;

namespace Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            bool endGame = false;
            string inputStr;

            do{
                Console.WriteLine("Let's Begin:");

                // Get user input
                inputStr = Console.ReadLine();

                if(inputStr == "exit") {
                    break;
                }

                try{

                    // Stip whitespace
                    string trimmedStr = String.Concat(inputStr.Where(c => !Char.IsWhiteSpace(c)));

                    // Set to lower case
                    string lowerStr = trimmedStr.ToLower();

                    // Remove punctuation
                    string readyStr = new string(lowerStr.Where(c => !char.IsPunctuation(c)).ToArray());

                    (bool, int) result = IsPalindrome(readyStr);
                    Console.WriteLine($"Palindrome: {result.Item1}, Length: {result.Item2}");

                }catch{

                }

            }while(!endGame);

        }

        static (bool, int) IsPalindrome(string readyStr) {
            char[] charArray = readyStr.ToCharArray();
            Array.Reverse(charArray);
            string reverseStr = new string(charArray);
            if(readyStr == reverseStr) {
                return (true, readyStr.Length);
            }else{
                return (false, 0);
            }
        }
    }
}
