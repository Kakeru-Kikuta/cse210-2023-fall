using System;

class Program
{
    static void Main(string[] args)
    {
        Video video = new Video();
        video._title = "video 1";
        video._author = "X";
        video._length = 120;

        Comment comment1 = new Comment();
        comment1._person = "Someone";
        comment1._comment = "1st comment.";

        video.comments.Add(comment1);

        Video video2 = new Video();
        video2._title = "video 2";
        video2._author = "Y";
        video2._length = 100;

        Comment comment2 = new Comment();
        comment2._person = "Someone1";
        comment2._comment = "2nd comment.";

        video.comments.Add(comment2);

        Video video3 = new Video();
        video3._title = "video 3";
        video3._author = "Z";
        video3._length = 130;

        Comment comment3 = new Comment();
        comment3._person = "Someone2";
        comment3._comment = "3rd comment.";

        video.comments.Add(comment3);
        
        video.Display();
    }
}