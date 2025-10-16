using CSharpLab;
using System.ComponentModel.Design;
using System.Runtime.InteropServices;


public static class Week2_WarmUp
{
    public static void Run()
    {
        Console.WriteLine("Week 2 Warm up Tasks is running");
    }

    public static void WarmUp1() // This program allows the user to repeatedly enter lap times (in seconds).
    {
        List<double> lapTimes = new List<double>(); // Create a list that will store all lap times entered by a user.

        Console.WriteLine("Enter Lap times in seconds"); // Here I ask the user to start entering lap times.


        while (true) 
        {
            Console.Write("Lap Time: ");
            string input = Console.ReadLine();
            if (double.TryParse(input, out double time)) // Here I Convert the users input from a string to a decimal (Double)
            {
                if (time == 0)
                {
                    Console.WriteLine("Ended from 0 Input"); break; // Exit the loop

                }
                lapTimes.Add(time); // If successful, it stores the Input lap time in the lapTimes list.
                // Console.WriteLine("Enter another Lap time: ");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter an appropriate Lap Time in seconds");
            }
        }
        if (lapTimes.Count > 0)
        {
            lapTimes.Sort(); // Here I sort the lap times in the list from fastest to slowest.

            double AvgTime = Average(lapTimes);

            Console.WriteLine($"Number of Laps: {lapTimes.Count}");
            Console.WriteLine($"Average Lap Times: {AvgTime}");

            foreach (double time in lapTimes)
            {
                Console.WriteLine($"{time:F2} Seconds");
            }
        }
        else
        {
            Console.WriteLine("No lap times were entered");
        }
        
    }
    public static double Average(List<double> lapTimes) // This function calculates the average
    {
        double total = 0;
        foreach (double t in lapTimes)
        {
            total += t;
        }
        return total / lapTimes.Count;
    }
}