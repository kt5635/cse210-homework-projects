// Showing Creativity and Exceeding Requirements: Added a user input so the user can enter their chosen scripture.

using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please enter your scripture verse (example: John 3:16): ");
        string referenceInput = Console.ReadLine();

        string[] referenceParts = referenceInput.Split(new char[] {' ', ':', '-'});

        string book = referenceParts[0];
        int chapter = int.Parse(referenceParts[1]);
        int verse = int.Parse(referenceParts[2]);
        int endVerse = referenceParts.Length == 4 ? int.Parse(referenceParts[3]) : verse;

        Console.WriteLine("Please enter the scripture text: ");
        string scriptureText = Console.ReadLine();

        var reference = new Reference(book, chapter, verse, endVerse);
        var scripture = new Scripture(reference, scriptureText);

        Console.WriteLine(scripture.GetDisplayText());
        Console.WriteLine("Press enter to continue or type 'quit' to finish");

        while(true)
        {
            string input = Console.ReadLine();
            if (input?.ToLower() == "quit") break;

            scripture.HideRandomWords(3);
            Console.WriteLine(scripture.GetDisplayText());

            if (scripture.IsCompletelyHidden())
            {
                break;
            }
        }
    }
} 


