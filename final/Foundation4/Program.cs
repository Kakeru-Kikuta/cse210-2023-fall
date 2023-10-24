using System;

class Program
{
    static void Main(string[] args)
    {
        Running running = new Running( "01/18/2023", 1, 2);
        running.CalculateDistance();
        running.CalculateSpeed();
        running.CalculatePace();
        running.DisplaySummary();

        Cycling cycling = new Cycling("01/19/2023", 6, 10);
        cycling.CalculateSpeed();
        cycling.CalculateDistance();
        cycling.CalculatePace();
        cycling.DisplaySummary();

        Swimming swimming = new Swimming("01/20/2023", 30, 40);
        swimming.CalculateDistance();
        swimming.CalculateSpeed();
        swimming.CalculatePace();
        swimming.DisplaySummary();

        ActManager actManager = new ActManager();
        actManager.AddActivity(running);
        actManager.AddActivity(cycling);
        actManager.AddActivity(swimming);
    }
}