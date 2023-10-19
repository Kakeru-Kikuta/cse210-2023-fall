using System;
using System.Security.Cryptography.X509Certificates;

class Cycling: Activity
{
    private float _speed;

    public Cycling(string date, float actLength, float speed): base(date,actLength)
    {
        _speed = speed;
    }

    public override float CalculateDistance()
    {
        return CalculateSpeed() * _actLength;
    }
    public override float CalculateSpeed()
    {
        return _speed;
    }
    public override float CalculatePace()
    {
        return _actLength / CalculateDistance();
    }
}