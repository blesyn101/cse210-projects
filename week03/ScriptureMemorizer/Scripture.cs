using System;
using System.Collections.Generic;

public class Scripture
{
    // Private attributes
    private Reference _reference;
    private List<Word> _words;

    // Constructor
    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

    // Split the scripture into individual words
    string[] words = text.Split(' ');

    // Go through each word and create a Word object
    foreach (string word in words)
        {
            Word newWord = new Word(word);
            _words.Add(newWord);
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();

        List<Word> visibleWords = new List<Word>();

        // Find words that are not hiddden yet
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                visibleWords.Add(word);
            }
        }

        // Hide random words
        for (int i = 0; i < numberToHide && visibleWords.Count > 0; i++)
        {
            int index = random.Next(visibleWords.Count);

            visibleWords[index].Hide();

            visibleWords.RemoveAt(index);
        }

    }

    public string GetDisplayText()
    {
     string displayText = $"{_reference.GetDisplayText()}";
     
    // Display each word
    foreach (Word word in _words)
        {
            displayText += $"{word.GetDisplayText()} ";
        } 
        return displayText.Trim();
    }

    public bool IsCompletelyHidden()
    {
        // check if all words are hidden
        foreach (Word word in _words)
        {
         if (!word.IsHidden())
            {
                return false;
            }   
        }

            return true;
    }

}