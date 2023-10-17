using System;

class Video
{
    public string _title;
    public string _author;
    public int _length;

    public List<Comment> comments = new ();

    public void Display()
    {
        Console.WriteLine($"Title: {_title}\nAuthor: {_author} Length: {_length}");
        foreach(Comment comment in comments)
        {
            comment.Display();
        }
    }
    
}