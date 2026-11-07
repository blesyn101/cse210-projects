using System;
using System.IO;
using System.Collections.Generic;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    // Method to add a new entry to the journal
    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    // Method to display all entries in the journal
    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
            Console.WriteLine(); // Add a blank line between entries
        }
    }

    // Method to save to file
    public void SaveToFile(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename)) //writes information into file
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._date}~|~{entry._promptText}~|~{entry._entryText}");
            }
        }
    }

    // Method to load from file
    public void LoadFromFile(string filename)
    {
        if (File.Exists(filename))
        {
            _entries.Clear(); // Clear existing entries before loading new ones
            
            string[] lines = System.IO.File.ReadAllLines(filename); //reads all lines from a file

            foreach (string line in lines)
            {
                string[] parts = line.Split("~|~"); //separates the date, prompt and response and i used ~|~ according to the instructions in the assignment

                if (parts.Length == 3)
                {
                    Entry entry = new Entry();

                    entry._date = parts[0];
                    entry._promptText = parts[1];
                    entry._entryText = parts[2];
                    
                    _entries.Add(entry);

                }
            }
        } else
        {
            Console.Write($"{filename} does not exist.");
        }
    }


}