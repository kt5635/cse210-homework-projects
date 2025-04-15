using System;

public abstract class Activity
{
    private string _activityType;
    private int _date;
    protected double _length;

    public Activity(string type, int date, double length)
    {
        _activityType = type;
        _date = date;
        _length = length;
    }

    public abstract double CalculateSpeed();
    public abstract double CalculateDistance();
    public abstract double CalculatePace();

    public virtual string GetSummary()
    {
        return $"{_activityType} on {_date}: {_length} minutes";
    }
}



