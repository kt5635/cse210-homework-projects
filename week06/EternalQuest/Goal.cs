using System;

public class Goal
{
    protected string _shortName;
    protected string _description;
    protected string _points;

    public Goal(string shortName, string description, string points)
    {
        _shortName = shortName;
        _description = description;
        _points = points;
    }
    
    public virtual void RecordEvent()
    {
        Console.WriteLine($"Even recorded for goal: {_shortName}");
    }
    public virtual bool IsComplete()
    {
        return false;
    }
    public virtual string GetDetailsString()
    {
        return $"Goal: {_shortName}\nDescription: {_description}\nPoints: {_points}";
    }
    public virtual string GetStringRepresentation()
    {
        return $"Goal,{_shortName},{_description},{_points}";
    }
    public virtual string GetPoints()
    {
        return _points;
    }
}