using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        var reference = new Reference("John", 3, 16);
        var scriptureText = "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.";
        var scripture = new Scripture(reference, scriptureText);

        Console.WriteLine(scripture.GetDisplayText());
        Console.WriteLine("Press enter to continue or type 'quit' to finish");

        while(true)
        {
            string input = Console.ReadLine();
            if (input?.ToLower() == "exit") break;

            scripture.HideRandomWords(2);
            Console.WriteLine(scripture.GetDisplayText());

            if (scripture.IsCompletelyHidden())
            {
                break;
            }
        }
    }
}