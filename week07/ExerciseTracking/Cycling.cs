using System;

public class Cycling : Activity
{
    private int _speed;

    public Cycling(int speed, string type, DateTime date, double length) :base(type, date, length)
    {
        _speed = speed;
    }

    public override double CalculateSpeed()
    {
        return _speed;
    }
    public override double CalculateDistance()
    {
        return _speed * _length /60;
    }
    public override double CalculatePace()
    {
        double distance = CalculateDistance();
        return distance > 0 ? _length / distance : 0;
    }
    public override string GetSummary()
    {
        return base.GetSummary();
    }

}
