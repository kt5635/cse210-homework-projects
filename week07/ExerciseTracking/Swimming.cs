using System;

public class Swimming : Activity
{
    private int _laps;

    public Swimming(int laps, string type, DateTime date, double length) :base(type, date, length)
    {
        _laps = laps;
    }

    public override double CalculateSpeed()
    {
        double distance = CalculateDistance();
        return distance / (_length/60);
    }
    public override double CalculateDistance()
    {
        return _laps * 50 / 1000.0;
    }
    public override double CalculatePace()
    {
        double distance = CalculateDistance();
        return distance > 0 ? _length / distance : 0;
    }
    public override string GetSummary()
    {
        return $"{base.GetSummary()}, laps {_laps}";
    }
}