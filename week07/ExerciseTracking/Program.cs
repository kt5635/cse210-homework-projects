using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        activities.Add(new Cycling(25, "Cycling", new DateTime(2025, 4, 3), 60));
        activities.Add(new Running(10, "Running", new DateTime(2025, 4, 1), 50));
        activities.Add(new Swimming(30, "Swimming", new DateTime(2025, 4, 5), 45));

        Console.WriteLine("Activity Summary:");
        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }

    }
}