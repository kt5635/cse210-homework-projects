using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;

public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity(string name, string description, int duration) : base(name, description, duration)
    {
    }
    public void Run()
    {
        DisplayStartingMessage();

        Console.WriteLine("List as many responses you can to the following prompt:");
        string prompt = GetRandomPrompt();
        Console.WriteLine($"--- {prompt} ---");
        Console.WriteLine("You may begin in: ");
        ShowCountDown(3);

        string userList = GetListFromUser();
        int count = userList.Split(" ").Length;
        
        Console.WriteLine($"\nYou have {count} items in your list.");
        Console.WriteLine("Your List:");
        Console.WriteLine(userList);

        DisplayEndingMessage();
    }
    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }
    public string GetListFromUser()
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        
        Console.WriteLine("Start listing: ");
        List<string> userItems = new List<string>();
        
        while (DateTime.Now < endTime)
        {
            string input = Console.ReadLine();
            
            userItems.Add(input);
        }

        return string.Join(", ", userItems);
    }
}