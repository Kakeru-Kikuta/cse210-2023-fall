using System;

public abstract class Activity
{
    protected string _date;
    protected float _actLength;

    public Activity(string date, float actLength)
    {
        _date = date;
        _actLength = actLength;
    }

    public abstract float CalculateDistance();
    public abstract float CalculateSpeed();
    public abstract float CalculatePace();
    public void DisplaySummary()
    {
        Console.WriteLine($"{_date} {GetType()} ({_actLength} min) Distance: {CalculateDistance()} km Speed: {CalculateSpeed()} kph Pace: {CalculatePace()} km");
    }
}