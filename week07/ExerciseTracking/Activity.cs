using System;

public abstract class Activity
{
    private string _activityType;
    private  DateTime _date;
    protected double _length;

    public Activity(string type, DateTime date, double length)
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
        return $"{_date:dd MMM yyyy} {_activityType} ({_length} min): Distance {CalculateDistance()} km, Speed {CalculateSpeed()} kph, Pace {CalculatePace()} min per km";
    }
}



