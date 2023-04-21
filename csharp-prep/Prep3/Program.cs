using System;

class Program
{
    static void Main(string[] args)
    {
        // Ask user for the magic number.
        // Console.Write("What is the magic number? ");
        // string userMagicNum = Console.ReadLine();
        // int magicNumber = int.Parse(userMagicNum);
        
        // Generat a random number from 1 - 100
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1,100);

        int guessNumber = 0;
        // int totalGuesses = 0;

        // Loop as long as guess does not match magic number
        while (guessNumber != magicNumber)
        {
            // Ask the user for a guess
            Console.Write("What is your guess? ");
            string userGuessNum = Console.ReadLine();
            guessNumber = int.Parse(userGuessNum);
            string displayPrompt = "";

            // Determine if user needs to guess higher or lower 
            if (guessNumber > magicNumber)
            {
                displayPrompt = "Lower";
            }
            else if (guessNumber < magicNumber)
            {
                displayPrompt = "Higher";
            }
            else
            {
                displayPrompt = "You guessed it!";
            }
            Console.WriteLine($"{displayPrompt}");

            // totalGuesses = guessNumber.Count;
            // Console.WriteLine($"You guessed {totalGuesses} times.");
        }
        
        
    }
}