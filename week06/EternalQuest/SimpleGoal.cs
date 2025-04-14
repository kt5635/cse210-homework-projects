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
    public void MarkComplete(bool IsComplete)
    {
        _isComplete = IsComplete;
    }
    public override string GetStringRepresentation()
    {
        return $"SimpleGoal|{_shortName}|{_description}|{_points}|{_isComplete}";
    }
    public override string GetDetailsString()
    {
        return (_isComplete ? "[X]" : "[ ]") + $" {_shortName} ({_description})";
    }
}