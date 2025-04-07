// Showing Creativity and Exceeding Requirements: Added a list on the ReflectingActivity class that keeps questions from getting repeated until all questions have been used.

using System;

class Program
{
    static void Main(string[] args)
    {
        while(true)
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine("   1. Start breathing activity");
            Console.WriteLine("   2. Start reflecting activity");
            Console.WriteLine("   3. Start listing activity");
            Console.WriteLine("   4. Quit");
            Console.Write("Select a choice from the menu: ");

            int choice = int.Parse(Console.ReadLine());

            if (choice == 1) 
            {
                BreathingActivity breathing = new BreathingActivity(
                    "Breathing Activity",
                    "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.",
                    0
                );
                breathing.Run();
            }

            else if (choice == 2) 
            {
                ReflectingActivity reflecting = new ReflectingActivity(
                    "Reflecting Activity",
                    "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.",
                    0
                );
                reflecting.Run();
                
            }

            else if (choice == 3) 
            {
                ListingActivity listing = new ListingActivity(
                    "Listing Activity",
                    "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.",
                    0
                );
                listing.Run();
                
            }

            else if (choice == 4) 
            {
                Console.Write("\nHave a great Day!");
                break;
            }
        }
    }
}