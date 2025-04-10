using System;

public class Goal
{
    private string _shortName;
    private string _description;
    private string _points;

    public Goal(string shortName, string description, string points)
    {
        _shortName = shortName;
        _description = description;
        _points = points;
    }
    
    public virtual void RecordEvent()
    {

    }
    public virtual bool IsComplete()
    {
        
    }
    public string GetDetailsString()
    {

    }
    public virtual string GetStringRepresentation()
    {

    }
}