using System;

class Program
{
    static void DisplayMessage()
    {
        Console.WriteLine("Welcome to the program!");
    }
    static string PromptUserName()
    {
        Console.WriteLine("What is your name? ");
        string username = Console.ReadLine();
        return username;
    }
    static int PromptUserNumber()
    {
        Console.WriteLine("What is your favorite number? ");
        int number = int.Parse(Console.ReadLine());
        return number;
    }
    static int SquareNumber(int number)
    {
        int square= number * number;
        return square;
    }
    static void DisplayResult(string username, int square)
    {
        Console.WriteLine($"{username}, your favorite number squared is {square}!");
    }
    static void Main(string[] args)
    {
        DisplayMessage();
        string username = PromptUserName();
        int number = PromptUserNumber();
        int square = SquareNumber(number);
        DisplayResult(username, square);
    }
}