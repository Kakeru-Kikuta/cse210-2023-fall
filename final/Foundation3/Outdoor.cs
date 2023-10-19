using System;

class Outdoor: Event
{
    private string _cloudFormation;
    private int _temp;
    private bool _rain;

    public Outdoor(string eventTitle, string description, string date, string time, string address, string cloudFormation, int temp, bool rain) : base(eventTitle, description, date, time, address)
    {
        _cloudFormation = cloudFormation;
        _temp = temp;
        _rain = rain;
    }
    public string DisplayFullDetails()
    {
        return DisplayStandardDetails() + $" {_cloudFormation} Temperature:{_temp} Rain:{_rain}";
    }

}