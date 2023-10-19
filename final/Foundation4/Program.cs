using System;

class Program
{
    static void Main(string[] args)
    {
        Running running = new Running( "01/18/2023", 1, 2);
        running.DisplaySummary();

        Cycling cycling = new Cycling("01/18/2023", 1, 2);
        cycling.DisplaySummary();

        Swimming swimming = new Swimming("01/18/2023", 1, 2
        );
        swimming.DisplaySummary();

        ActManager actManager = new ActManager();
        actManager.AddActivity();
    }
}