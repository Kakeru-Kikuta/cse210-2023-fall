using System;
using System.Net.Http.Headers;

class Event
{
    private string _eventTitle;
    private string _description;
    private string _date;
    private string _time;
    private string _address;

    public Event(string eventTitle, string description, string date, string time, string address)
    {
        _eventTitle = eventTitle;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }

    public string DisplayStandardDetails()
    {
        return $"{_eventTitle}: {_description}, {_date}, {_time}, {_address}";
    }
    
    public string DisplayShortDescription()
    {
        return $"{GetType()} {_eventTitle} {_date}";
    }
}