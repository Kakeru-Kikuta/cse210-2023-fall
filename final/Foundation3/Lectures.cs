using System;

class Lectures: Event
{
    private string _speaker;
    private int _capacity;

    public Lectures(string eventTitle, string description, string date, string time, string address, string speaker, int capacity) : base(eventTitle, description, date, time, address)
    {
        _capacity = capacity;
        _speaker = speaker;
    }

    public string DisplayFullDetails()
    {
        return DisplayStandardDetails() + $" {_speaker} {_capacity}";
    }

}