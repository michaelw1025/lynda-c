using System;
using System.Globalization;

namespace Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            // Choose a random number between 0 and 20
            int theNumber = new Random().Next(20);

            // Print the game greeting and instructions
            Console.WriteLine("Let's Play 'Guess the Number'!");
            Console.WriteLine("I'm thinking of a number between 0 and 20.");
            Console.WriteLine("Enter your guess, or -1 to give up.");

            // Keep track of the number of guesses and the current user guess
            string inputGuess;
            int parsedGuess = 100;
            int numberGuesses = 0;

            //Start the game and run until user quits or guesses correctly
            // Hint: You'll need a way to convert the user's input to an integer
            do{
                Console.WriteLine("What's your guess?");
                // Get the user's guess
                inputGuess = Console.ReadLine();
                // Increment the guess counter
                numberGuesses++;
                //Try to parse the guess into an int
                try {
                    bool succeeded = false;
                    succeeded = Int32.TryParse(inputGuess, out parsedGuess);
                    if(succeeded) {
                        if(parsedGuess == -1){
                            Console.WriteLine("You quit the game.");
                            break;
                        }
                        if(parsedGuess == theNumber) {
                            Console.WriteLine($"You got it in {numberGuesses} guesses!!");
                        } else {
                            Console.WriteLine("Nope, {0} than that.", parsedGuess < theNumber ? "higher" : "lower");
                        }
                    }else{
                        throw new FormatException("Hmmm, that doesn't look like a number.  Try again.");
                    }

                }catch (FormatException e){
                    Console.WriteLine(e.Message);
                }
                
            }while(parsedGuess != theNumber);
            
        }
    }
}
