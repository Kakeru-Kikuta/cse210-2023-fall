using System;

class Running: Activity
{
    private float _runDistance;

    public Running(string date, float actLength, float runDistance): base(date,actLength)
    {
        _runDistance = runDistance;
    }
    
    public override float CalculateDistance()
    {
        return _runDistance;
    }
    public override float CalculateSpeed()
    {
        return _runDistance / (_actLength * 60);
    }
    public override float CalculatePace()
    {
        return _actLength / _runDistance;
    }
}