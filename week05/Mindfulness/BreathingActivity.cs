using System;

public class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description, int duration) : base(name, description, duration)
    {
    }
    public void Run()
    {
        DisplayStartingMessage();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("Breathe in...");
            ShowCountDown(5);
            Console.WriteLine();
            Console.Write("Now breathe out...");
            ShowCountDown(5);
            Console.WriteLine();
        }

        DisplayEndingMessage();
    }
    
}