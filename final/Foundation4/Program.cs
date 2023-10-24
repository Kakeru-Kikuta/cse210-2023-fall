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
        //The calculations for cycling and swimming don't use hard-coded numbers, so I'm not getting the results I expected, but I don't know how to solve that problem.
        //01/18/2023 Running (1 min) Distance: 2 km Speed: 120 kph Pace: 0.5 km
        //01/19/2023 Cycling (2 min) Distance: 6 km Speed: 3 kph Pace: 0.33333334 km
        //01/20/2023 Swimming (3 min) Distance: 0 km Speed: 0 kph Pace: ∞ km
    }
}