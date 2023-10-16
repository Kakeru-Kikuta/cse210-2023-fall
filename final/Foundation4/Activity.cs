using System;

public abstract class Activity
{
    private string _date;
    private int _actLength;

    public Activity(string date, int actLength)
    {
        _date = date;
        _actLength = actLength;
    }

    public abstract int CalculateDistance();
    public abstract int CalculateSpeed();
    public abstract int CalculatePace();
    public abstract string DisplaySummary();
}