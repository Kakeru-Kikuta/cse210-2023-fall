using System;

class Swimming: Activity
{
    private int _numOfLaps;

    public Swimming(string date, float actLength, int numOfLaps): base(date,actLength)
    {
        _numOfLaps = numOfLaps;
    }

    public override float CalculateDistance()
    {
        return _numOfLaps * 50 / 1000;
    }
    public override float CalculateSpeed()
    {
        return CalculateDistance() / _actLength;
    }
    public override float CalculatePace()
    {
        return _actLength / CalculateDistance();
    }
}