using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> num = new List<int>();
        int userNum = -1;
        while (userNum !=0 )
        {
             Console.Write("Enter a number (0 to quit): ");
            
            string userResponse = Console.ReadLine();
            userNum = int.Parse(userResponse);

             if (userNum != 0)
            {
                num.Add(userNum);
            }
        }
            int sum = 0;
        foreach (int number in num)
        {
            sum += number;
        }

        Console.WriteLine($"The sum is: {sum}");

        float average = ((float)sum) / num.Count;
        Console.WriteLine($"The average is: {average}");

        int max = num[0];

        foreach (int number in num)
        {
            if (number > max)
            {
                // if this number is greater than the max, we have found the new max!
                max = number;
            }

        }

        Console.WriteLine($"The max is: {max}");
    }
}