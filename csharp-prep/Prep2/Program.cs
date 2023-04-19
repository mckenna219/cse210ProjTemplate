using System;

class Program
{
    static void Main(string[] args)
    {
        // Request grade percentage from user
        Console.Write("What is your grade percentage? ");
        string userAnswer = Console.ReadLine();
        int userPercentage = int.Parse(userAnswer);
        string letterGrade = "";

        //Convert user input (percentage) to letter grade
        if (userPercentage >= 90)
        {
            letterGrade = "A";
        }
        else if (userPercentage >= 80)
        {
            letterGrade = "B";
        }
        else if (userPercentage >= 70)
        {
            letterGrade = "C";
        }
        else if (userPercentage >= 60)
        {
            letterGrade = "D";
        }
        else
        {
            letterGrade = "F";
        }
        Console.WriteLine($"Your letter grade is: {letterGrade}.");
        
        if (userPercentage > 70)
        {
            Console.WriteLine("Congrats! You passed the class.");
        }       
        else
        {
            Console.WriteLine("Better luck next time.");
        } 
    }


        
    }
