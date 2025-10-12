using CSharpLab;
using System.ComponentModel.Design;
using System.Runtime.InteropServices;


public static class Week2_WarmUp
{
    public static void Run()
    {
        Console.WriteLine("Week 2 Warm up Tasks is running");
    }

    public static void WarmUp1()
    {
        List<double> lapTimes = new List<double>();

        Console.Write("Enter Lap times in seconds:");
        string input = Console.ReadLine();


        while (true)
        {
            if (double.TryParse(input, out double time))
            {
                if (time == 0)
                {
                    Console.WriteLine("Ended from 0 Input"); break;
                }
                lapTimes.Add(time);
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
        }
    }

}