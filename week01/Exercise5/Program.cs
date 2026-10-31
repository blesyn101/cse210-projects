using System;

class Program
{
    static void Main(string[] args)
    {
      // Display welcome message
        DisplayWelcome();

        // Get the user's name
        string userName = PromptUserName();

        // Get the user's favorite number
        int userNumber = PromptUserNumber();

        // Calculate the square of the number
        int squaredNumber = SquareNumber(userNumber);

        // Display the result
        DisplayResult(userName, squaredNumber);
    }
    

    static void DisplayWelcome ()
        {
        Console.WriteLine("Welcome to the program!");
        }

        static string PromptUserName  ()
        {
        Console.Write("Please enter your name: ");
        string userName = Console.ReadLine();
        return userName;
        }

        static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        string fav = Console.ReadLine();

        //convert fav from string to int
        int favNumber = int.Parse(fav);
        return favNumber;
    }

    static int SquareNumber (int number)
    {
        int squareNumber = number * number;
        return squareNumber;
    }

    static void DisplayResult (string userName, int squareNumber)
    {
        Console.WriteLine($"{userName}, the square of your number is {squareNumber}");
    }

}