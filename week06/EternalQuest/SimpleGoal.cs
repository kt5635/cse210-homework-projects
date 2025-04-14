using System;

public class SimpleGoal: Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description, string points) : base(name, description, points)
    {
    }

    public override void RecordEvent()
    {
        _isComplete = true;
        Console.WriteLine($"Congratulations! you have completed the goal: {_shortName}");
    }
    public override bool IsComplete()
    {
        return _isComplete;
    }
    public override string GetStringRepresentation()
    {
        return $"SimpleGoal|{_shortName}|{_description}|{_points}|{_isComplete}";
    }
    public override string GetDetailsString()
    {
        return $"{_shortName}: {_description} (Points: {_points}) - " +
            (_isComplete ? "[X]" : "[ ]");
    }
}