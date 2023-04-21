using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcomeMessage();
        string userName = GetUserName();
        int faveNum = GetFavoriteNumber();
        int squaredNum = GetSquaredNumber(faveNum);
        DisplayResult(userName, squaredNum);
    }

    // Display welcome message
    static void DisplayWelcomeMessage()
    {
        Console.WriteLine("Welcome to the Program!");
    }


    // Prompt user for name
    static string GetUserName()
    {
        Console.Write("Please enter your name: ");
        string userName = Console.ReadLine();

        return userName;
    }


    // Prompt user for number
    static int GetFavoriteNumber()
    {
        Console.Write("Please enter your favorite number: ");
        string favoriteNumber = Console.ReadLine();
        int faveNum = int.Parse(favoriteNumber);

        return faveNum;
    }


    // Square users favorite number
    static int GetSquaredNumber(int faveNum)
    {
        int squaredNum = faveNum * faveNum;

        return squaredNum;
    }


    // Display result
    static void DisplayResult(string userName, int squaredNum)
    {
        Console.WriteLine($"{userName}, the square of your number is {squaredNum}.");
    }
}