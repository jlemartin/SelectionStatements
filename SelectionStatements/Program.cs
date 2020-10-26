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

            Console.WriteLine();
            // Part 2: switch/case
            Console.WriteLine("What is your favorite school subject?");
            Console.WriteLine("1 for Math");
            Console.WriteLine("2 for English");
            Console.WriteLine("3 for History");
            Console.WriteLine("4 for Science");
            Console.WriteLine("5 for Lunch");


            int favSubject = Convert.ToInt32(Console.ReadLine());

            switch (favSubject)
            {
                case 1:
                    Console.WriteLine("Yeah, that adds up for you!");
                    break;
                case 2:
                    Console.WriteLine("Sorry to interrupt your reading!");
                    break;
                case 3:
                    Console.WriteLine("Ah yes, now I remember!");
                    break;
                case 4:
                    Console.WriteLine("She blinded me with science!");
                    Console.WriteLine("Poetry in motion.");
                    break;
                case 5:
                    Console.WriteLine("I wonder what they are having in the cafeteria today?");
                    break;
                default:
                    Console.WriteLine("Not paying attention?");
                    break;
            }



        }
    }
}
