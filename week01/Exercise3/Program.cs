using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.Write("What is the magic number? ");
        // string number = Console.ReadLine();
        // int magicNumber = int.Parse(number);

        // generate a random number from 1 to 100
        Random random = new Random();
        int magicNumber = random.Next(1, 101);

        int guess = -1;

        

        while (guess !=magicNumber)
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            if (guess < magicNumber)
            {
                Console.WriteLine("Higher");
            }
            else if (guess > magicNumber)
            {
                Console.WriteLine("Lower");
            } 
        }
        Console.WriteLine("You guessed it!");

    }
}