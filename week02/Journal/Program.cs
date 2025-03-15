using System;
using System.Collections.Generic;
using System.IO;

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
                journal.LoadFromFile("journal.txt");
            }

            else if (choice == 4){
                journal.SaveToFile("journal.txt");
            }

            else if (choice == 5){
                Console.Write("Have a great Day!");
            }

        }

    }
}