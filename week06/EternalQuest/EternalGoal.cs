using System;

public class EternalGoal: Goal
{
    public EternalGoal(string name, string description, string points) : base(name, description, points)
    {
    }

    public override void RecordEvent()
    {
        Console.WriteLine($"Congratulations! you have earned {_points}!");
    }
    public override bool IsComplete()
    {
        return false;
    }
    public override string GetStringRepresentation()
    {
        return $"EternalGoal|{_shortName}|{_description}|{_points}";
    }
    public override string GetDetailsString()
    {
        return (IsComplete() ? "[X]" : "[ ]") + $" {_shortName} ({_description})";
    }
}