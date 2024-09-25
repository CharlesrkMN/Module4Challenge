using System;
using System.Threading;
using System.Xml.Serialization;

namespace GuessingGameApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Random Number Guessing Game!");//greet user
            Console.WriteLine("The computer is thinking of a number (1-100), try and guess which number it's thinking of!");

            // Generate a random number between 1 and 100
            Random random = new Random();
            int targetNumber = random.Next(1, 101);

            //do-while loop prompting the user to guess until the correct number
            int guess;
            do
            {
                Console.WriteLine("Enter a Guess: ");

                if (int.TryParse(Console.ReadLine(), out guess))
                {
                    if (guess == targetNumber) //if user guesses correctly
                    {
                        Console.WriteLine("Your guess is correct!");
                    }
                        
                    if (guess > targetNumber) //if users guess is too high
                    {
                        Console.WriteLine("Too high!");
                    }

                    if (guess < targetNumber) //if users guess is too low
                    {
                        Console.WriteLine("Too low!");
                    }

                    if (guess != targetNumber) //tell user to try again if incorrect
                    {
                        Console.WriteLine("Incorrect! Try again!");
                    }
                }
                else //else statement incase user doesnt enter a number
                {
                    Console.WriteLine("Invalid! Please enter a number!");
                    guess = 0;
                }
            } while (guess != targetNumber); //exit do-while loop if guess is incorrect
            Console.WriteLine("Congratulations! Thanks for playing!"); //congratulate the user for guessing correctly

        }
    }
}
