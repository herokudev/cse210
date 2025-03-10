using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise5 Project.");
        DisplayWelcome();
        string name = PromptUserName();
        int number = PromptUserNumber();
        int sNumber = SquareNumber(number);
        Console.WriteLine($"{name}, the square of your number is {sNumber}");
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string userInput = Console.ReadLine();
        return userInput;
    }


    static int PromptUserNumber()
    {
        int input;
        Console.Write("Please enter your favorite number: ");
        string userInput = Console.ReadLine();

        if (int.TryParse(userInput, out input)) return input;
        else return 0;
    }

    static int SquareNumber(int number)
    {
        return number * number;
    }

}
