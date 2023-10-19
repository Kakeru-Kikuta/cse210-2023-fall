using System;

class Program
{
    static void Main(string[] args)
    {
        Lectures lectures = new Lectures("Lecture Test", "This is a test.", "10/18/2023", "6:00 PM", "123 A ST", "Mr. John", 100);
        Console.WriteLine(lectures.DisplayStandardDetails());
        Console.WriteLine(lectures.DisplayFullDetails());
        Console.WriteLine(lectures.DisplayShortDescription());

        Outdoor outdoor = new Outdoor("Outdoor Test", "This is a test.", "10/18/2023", "6:00 PM", "124 B ST", "Non", 75, false);
        Console.WriteLine(outdoor.DisplayStandardDetails());
        Console.WriteLine(outdoor.DisplayFullDetails());
        Console.WriteLine(outdoor.DisplayShortDescription());

        Reception reception = new Reception("Reception Test", "This is a test.", "10/18/2023", "6:00 PM", "125 C ST", "test@mail.com");
        Console.WriteLine(reception.DisplayStandardDetails());
        Console.WriteLine(reception.DisplayFullDetails());
        Console.WriteLine(reception.DisplayShortDescription());
    }
}