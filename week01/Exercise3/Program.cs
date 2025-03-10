using System;

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        Console.WriteLine("Hello World! This is the Exercise3 Project.");

        int targetNumber = random.Next(1, 101); // Generates a number between 1 and 100
        int guess = 0;

        Console.WriteLine("I'm thinking of a number between 1 and 100. Can you guess what it is?");
        while (guess != targetNumber)
        {
            Console.Write("Enter your guess: ");
            if (int.TryParse(Console.ReadLine(), out guess))
            {
                if (guess < 1 || guess > 100)
                {
                    Console.WriteLine("Please enter a number between 1 and 100.");
                }
                else if (guess < targetNumber)
                {
                    Console.WriteLine("Too low! Try again.");
                }
                else if (guess > targetNumber)
                {
                    Console.WriteLine("Too high! Try again.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        }

        Console.WriteLine($"Congratulations! You guessed the number {targetNumber}.");
    }
}
