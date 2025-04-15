using System;

public class Running : Activity
{
    private double _distance;

    public Running(int distance, string type, DateTime date, double length) :base(type, date, length)
    {
        _distance = distance;
    }

    public override double CalculateSpeed()
    {
        return _distance / (_length /60);
    }
    public override double CalculateDistance()
    {
        return _distance;
    }
    public override double CalculatePace()
    {
        return _distance > 0 ? _length / _distance : 0;
    }
    public override string GetSummary()
    {
        return base.GetSummary();
    }
}