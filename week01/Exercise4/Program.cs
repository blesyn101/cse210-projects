using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        int enteredNumber = -1;

        
        // Collect numbers. I'm using a do while here
        do
        {
            Console.WriteLine("Enter a list of numbers, type 0 when finished.");
            Console.Write("Enter number: ");

            string response = Console.ReadLine();
            enteredNumber = int.Parse(response);
            
            if (enteredNumber !=0)
            {
                numbers.Add(enteredNumber);
            }
        } while (enteredNumber !=0);

        // check if the number is empty
        if (numbers.Count>0)
        {


        // 1 Compute the sum, or total, of the numbers in the list.
        int sum = 0;

        foreach (int num in numbers)
        {
            sum += num;
        }

        Console.WriteLine($"The sum is {sum}");
        

        // 2 Compute the average of the numbers in the list.
        double average = (double)sum / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        // 3 Find the maximum, or largest, number in the list.
        int largestNum = numbers[0]; //starting my largest number from [0] instead of 0 makes easy for user to enter negative number without crashing
        
        foreach (int num in numbers)
        if (num > largestNum)
            {
             largestNum = num; 
            }  
            Console.WriteLine($"The largest number is: {largestNum} ");  
        
        //sort numbers
        numbers.Sort();
        Console.WriteLine("The sorted list is:");
        foreach (int num in numbers)
        {
        Console.WriteLine(num);
        }
    }
    else
        {
            Console.WriteLine("No numbers were entered, please enter a valid number");
        }
    }
}