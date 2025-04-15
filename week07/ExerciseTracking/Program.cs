using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        activities.Add(new Cycling(25, "Cycling", 20230410, 60));
        activities.Add(new Running(10, "Running", 20230410, 50));
        activities.Add(new Swimming(30, "Swimming", 20230410, 45));

        Console.WriteLine("Activity Summary:");
        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }

    }
}