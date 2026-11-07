using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
       Journal journal = new Journal();
       
       List<string> prompts = new List<string>()
        {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "What am i greatful for?",
            "If I had one thing I could do over today, what would it be?"
        };

        Random random = new Random();

        
        // Initialize choice 
        string choice = "";

        // I'm using a while loop to determin the choice prompt user response to

        while (choice != "5")
        {
            Console.WriteLine("\nWelcome to the Journal Program!"); // Leanrt this from python😁 \n adds line above to seperate the programm display
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Exit");

            Console.Write("What would you like to do?");
            choice = Console.ReadLine();

            if (choice == "1")
            {
                int randomIndex = random.Next(prompts.Count);
                string randomPrompt = prompts[randomIndex];

                // Retrive the prompt and display it to the user
                Console.WriteLine(randomPrompt);
                string userResponse = Console.ReadLine();

                // Create a new entry and add it to the journal
                Entry newEntry = new Entry();

                newEntry._date = DateTime.Now.ToShortDateString();
                newEntry._promptText = randomPrompt;
                newEntry._entryText = userResponse;
                
                // Add the new entry to the journal
                journal.AddEntry(newEntry);
            } else if (choice == "2")
            {
                journal.DisplayAll();
            } else if (choice == "3")
            {
                Console.Write("Please enter filename to load: ");
                string filename = Console.ReadLine();

                // checkf if the file exists before, and if it does, load the journal from the file
                if (System.IO.File.Exists(filename))
                {
                    journal.LoadFromFile(filename);
                    // Console.WriteLine($"Journal loaded successfully from {filename}");
                } else // If the file does not exist, display an error message
                {
                    Console.WriteLine($"File {filename} does not exist. Cannot load journal.");
                }
            } else if (choice == "4")
            {
                Console.Write("Please enter filename to save: ");
                string filename = Console.ReadLine();

                journal.SaveToFile(filename);
                Console.WriteLine($"Journal saved successfully to {filename}");
            } else if (choice == "5")
            {
                Console.WriteLine("Goodbye!");
            } else // Handle invalid choice
            {
                Console.WriteLine("Invalid choice. Please select a valid option.");
            }
        }

        
    }
}