using System;
using System.Collections.Generic;

public class Activity {
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }
    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name}.");
        Console.WriteLine("");
        Console.WriteLine($"{_description}");
        Console.WriteLine("");
        Console.WriteLine("How long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());
        
        Console.WriteLine("Get ready...");
        ShowSpinner(3);
    }
    public void DisplayEndingMessage()
    {
        Console.WriteLine("Well done!!");
        Console.WriteLine("");
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name}.");
        Thread.Sleep(5000);
    }
    public void ShowSpinner(int seconds)
    {
        List<string> animationStrings = new List<string> {"|", "/", "-", "\\"};

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);

        int i = 0;

        while (DateTime.Now < endTime)
        {
            Console.Write(animationStrings[i]);
            Thread.Sleep(800);
            Console.Write("\b \b");

            i = (i + 1) % animationStrings.Count;
        }

    }
    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }

    }
}