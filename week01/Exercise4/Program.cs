using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");

        List<int> numbers = new List<int>();
        int input;

        Console.WriteLine("Enter numbers one by one (enter 0 to stop):");

        do
        {
            Console.Write("Enter a number: ");
            string userInput = Console.ReadLine();

            if (int.TryParse(userInput, out input))
            {
                if (input != 0)
                {
                    numbers.Add(input);
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }

        } while (input != 0);

        int ListSize = 0;
        int sumTotal = 0;
        int maxNumber = 0;

        Console.WriteLine("\nYou entered the following numbers:");
        foreach (int number in numbers)
        {
            ListSize++;
            Console.WriteLine(number);
            sumTotal = sumTotal + number;
            if (maxNumber < number) maxNumber = number;
        }
        double avegList = sumTotal / ListSize;

        Console.WriteLine($"Sum of all the numbers: {sumTotal}.");
        Console.WriteLine($"Average of the List: {avegList}.");
        Console.WriteLine($"The Largest number: {maxNumber}.");

    }
}
