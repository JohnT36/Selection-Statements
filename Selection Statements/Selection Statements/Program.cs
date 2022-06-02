using System;

namespace Selection_Statements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Welcome to the number guessing game!");
            Console.WriteLine($"See if you can guess the correct number!");
            Console.WriteLine($"Guess a number between 1-100");
            
            
            var random = new Random();
            var number = random.Next(1, 100);
            int input;
            do
            {

               input = int.Parse(Console.ReadLine());

                if (input == number)
                {
                    Console.WriteLine($"You are correct! Well done");
                }
                else if (input > number)
                {
                    Console.WriteLine($"You went tooo high! Take it down a notch. Try again");
                }
                else
                {
                    Console.WriteLine($"You are too low! Pick it up! Try again");

                }
            } while (input != number);
        }
    }
}
