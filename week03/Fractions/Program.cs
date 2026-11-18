using System;

class Program
{
    static void Main(string[] args)
    
    // Create fractions using 3 constructors
    {
        Fraction f1 = new Fraction();
        Fraction f2 = new Fraction(5);
        Fraction f3 = new Fraction(3, 4);
        Fraction f4 = new Fraction(1, 3);

        // Test the getters
        Console.WriteLine("Testing getters");

        Console.WriteLine(f3.GetTop());
        Console.WriteLine(f3.GetBottom());

        // Test the setters
        f3.SetTop(3);
        f3.SetBottom(4);

        Console.WriteLine("Testing setters");

        Console.WriteLine(f3.GetTop());
        Console.WriteLine(f3.GetBottom());

        // Display the fractions and their decimal values
        Console.WriteLine("Testing GetFractionString and GetDecimalValue");

        Console.WriteLine(f1.GetFractionString());
        Console.WriteLine(f1.GetDecimalValue());

        Console.WriteLine(f2.GetFractionString());
        Console.WriteLine(f2.GetDecimalValue());

        Console.WriteLine(f3.GetFractionString());
        Console.WriteLine(f3.GetDecimalValue());

        Console.WriteLine(f4.GetFractionString());
        Console.WriteLine(f4.GetDecimalValue());

    }
}