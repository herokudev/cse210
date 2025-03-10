using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");
        Console.Write("Enter the course score (0-100): ");

        string letter = "";
        if (int.TryParse(Console.ReadLine(), out int score))
        {
            if (score >= 90) letter = "A";
            else if (score >= 80) letter = "B";
            else if (score >= 70) letter = "C";
            else if (score >= 60) letter = "D";
            else letter = "F";
            Console.WriteLine($"The letter grade is: {letter}");
            if (score >= 70) Console.WriteLine("Congratulations you pass!!");
            else Console.WriteLine("Sorry, better luck for the next time.");
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter an integer between 0 and 100.");
        }
    }
}
