using System;

class Program
{
    static void Main(string[] args)
    {
        Random randnum = new Random();
        int number = randnum.Next(1,100);
        int userguess;
        do {
        Console.WriteLine("Guess the number: ");
        userguess = int.Parse(Console.ReadLine());
        if (userguess > number)
        {
            Console.WriteLine("Your guess is higher.");
        }
        else if (userguess < number)
        {
            Console.WriteLine("Your guess is lower.");
        }
        } while (userguess != number);

        Console.WriteLine($"You got it right! The answer is {number}.");
    }
}