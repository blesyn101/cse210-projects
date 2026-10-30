using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string grade = Console.ReadLine();
        int userGrade = int.Parse(grade);

        string letter  = "";

        if (userGrade >=90)
        {
            letter = "A";
        }
        else if (userGrade >= 80)
        {
            letter = "B";
        }
        else if (userGrade >= 70)
        {
            letter = "C";
        }
        else if (userGrade >=60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }
        Console.Write($"Your grade percentage is: {letter} ");

        // Condition to check if passed
        if (userGrade >=70)
        {
            Console.WriteLine("Congratulations, you passed");
        }
        else
        {
            Console.WriteLine("Sorry, Try harder");
        }
    }
}