using System;

class Reception: Event
{
    private string _email;
    public Reception(string eventTitle, string description, string date, string time, string address, string email) : base(eventTitle, description, date, time, address)
    {
        _email = email;
    }
    public string DisplayFullDetails()
    {
        return DisplayStandardDetails() + $" Email: {_email}";
    }

}