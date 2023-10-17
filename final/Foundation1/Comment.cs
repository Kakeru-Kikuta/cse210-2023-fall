using System;

class Comment
{
    public string _person;
    public string _comment;

    public void Display()
    {
        Console.WriteLine($"Name: {_person}\nComment: {_comment}");
    }
}