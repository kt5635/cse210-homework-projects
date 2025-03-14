using System;


class Program
{
    static void Main(string[] args)
    {
        int choice = -1;

        while(choice != 5)
        {
            Console.WriteLine("Welcome to the Journal Program");
            Console.WriteLine("Please select one of the following options:");
            Console.WriteLine("1. Write New Journal Entry");
            Console.WriteLine("2. Display Journal");
            Console.WriteLine("3. Load Journal");
            Console.WriteLine("4. Save Journal");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            choice = int.Parse(Console.ReadLine());

            if (choice == 1){

            }

            else if (choice == 2){
                
            }
            else if (choice == 3){
                
            }
            else if (choice == 4){
                
            }
            else if (choice == 5){
                Console.Write("Have a great Day!");
            }
        }

    }
}