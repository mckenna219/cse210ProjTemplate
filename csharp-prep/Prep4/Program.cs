using System;

class Program
{
    static void Main(string[] args)
        {
            // Create a list, append user specified numbers to the list
            // Declare initial number to be -1 so "while" loop will run
            List<int> numbers = new List<int>();
            int userNumber = -1;

            // Prompt for input from user
            Console.WriteLine("Enter a list of numbers, type 0 when finished. ");
            
            // Ask the user for a series of numbers
            // Stop when the user enters "0"
            while (userNumber != 0)
            {
                // Request numbers until user types "0"
                Console.Write("Enter number: ");
                string numberAnswer = Console.ReadLine();
                userNumber = int.Parse(numberAnswer);

                if (userNumber == 0)
                {
                    break;
                }

                // Add user input numbers to list
                numbers.Add(userNumber);
            }

            // Compute the sum of numbers in the list
            int sum = 0;
            foreach (int number in numbers)
            {
                sum += number;
            }

            // Display sum
            Console.WriteLine($"The sum is: {sum}");

            // Compute the average of the numbers in the list
            float avg = ((float)sum) / numbers.Count;
            
            // Display average
            Console.WriteLine($"The average is: {avg}");
            
            // Find the maximum, or largest, number in the list
            int largestNumber = numbers[0];

            foreach (int number in numbers)
            {
                if (number > largestNumber)
                {
                    largestNumber = number;
                }
            }


            // Display largest number
            Console.WriteLine($"The largest number is: {largestNumber}");

        
    }
}