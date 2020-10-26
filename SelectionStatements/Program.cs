using System;

namespace SelectionStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            // Part 1: if / else if

            // Set lowest and highest numbers
            int minNum = 1;
            int maxNum = 100;

            // Create random number between
            var r = new Random();
            var favNumber = r.Next(minNum, maxNum);

            // Time to guess the number
            Console.WriteLine($"Enter a number between {minNum} and {maxNum}:");
            var userInput = int.Parse(Console.ReadLine());

            // Evaluate the guess
            if (userInput < favNumber)
            {
                Console.WriteLine($"{userInput} is too low.");
                Console.WriteLine($"The answer was {favNumber}.");
            }
            else if (userInput > favNumber)
            {
                Console.WriteLine($"{userInput} is too high.");
                Console.WriteLine($"The answer was {favNumber}.");
            }
            else
            {
                Console.WriteLine("Never mind");
                Console.WriteLine($"How did you know the answer was {favNumber}?");
            }

            
        }
    }
}
