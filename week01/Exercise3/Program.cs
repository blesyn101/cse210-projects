using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is the magic number? ");
        string number = Console.ReadLine();
        int magicNumber = int.Parse(number);

        Console.Write("What is your guess?");
        int guess = int.Parse(Console.ReadLine());

        while (guess !=magicNumber)
        {
            if (guess < magicNumber)
            {
                Console.WriteLine("Higher");
            }
            else if (guess > magicNumber)
            {
                Console.WriteLine("Lower");
            }

                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("You guessed it!");

    }
}