using System;

class Program
{
    static void Main(string[] args)
    {
        // create a Reference object
        Reference reference = new Reference("John", 3, 16);

        // Store the scripture text
        string scriptureText = "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life.";

        // create a Scripture object
        Scripture scripture = new Scripture(reference, scriptureText);

        // Use while loop to hide words until all are hidden
        while (!scripture.IsCompletelyHidden())
        {
            // clear the console
            Console.Clear();

            // Display the scripture
            Console.WriteLine(scripture.GetDisplayText());

            Console.WriteLine();
            Console.WriteLine("Press Enter to continue or type 'quit' to finish");
            string input = Console.ReadLine();

            // End program if user types quit. i used trim and tolower to make it more user friendly to remove any extra spaces and make it case insensitive.
            if (input.Trim().ToLower() == "quit")
            {
                return;
            }

            // Hide 3 random words
            scripture.HideRandomWords(3);
        }

        // Display the final scripture with all words hidden
        Console.Clear();
        Console.WriteLine(scripture.GetDisplayText());


    }
}