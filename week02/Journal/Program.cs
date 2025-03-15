// Showing Creativity and Exceeding Requirements: Added code to save and laod journal information in a JSON file

using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        while(true)
        {
            Console.WriteLine("Welcome to the Journal Program");
            Console.WriteLine("Please select one of the following options:");
            Console.WriteLine("1. Write New Journal Entry");
            Console.WriteLine("2. Display Journal");
            Console.WriteLine("3. Load Journal");
            Console.WriteLine("4. Save Journal");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");

            int choice = int.Parse(Console.ReadLine());

            if (choice == 1){
                Entry newEntry = new Entry();

                Console.WriteLine($"Prompt: {newEntry._promptText}"); 
                newEntry._entryText = Console.ReadLine();
                journal.AddEntry(newEntry);
            }

            else if (choice == 2){

                journal.DisplayAll();
            }

            else if (choice == 3){
                Console.Write("Enter filename to load journal entries: ");
                string filename = Console.ReadLine();
                journal.LoadFromFile(filename);
            }

            else if (choice == 4){
                Console.Write("Enter filename: ");
                string filename = Console.ReadLine();
                journal.SaveToFile(filename);
            }

            else if (choice == 5){
                Console.Write("Have a great Day!");
                break;
            }

        }

    }
}