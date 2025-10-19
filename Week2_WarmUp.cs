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

        // Here I start an infinite loop until the user enters 0.
        while (true) 
        {
            Console.Write("Lap Time: "); // Here I ask the user for a single lap time.
            string input = Console.ReadLine(); // Read the user input as text (String)

            // TryParse returns true if the conversion is successful.
            if (double.TryParse(input, out double time)) // Here I Convert the users input from a string to a decimal (Double)
            {
                if (time == 0) // End the Infinite loop if the user enters 0, indicating the end of the program.
                {
                    Console.WriteLine("Ended from 0 Input"); break; // Exit the while loop
                }
                lapTimes.Add(time); // If Input is valid, it stores the Input lap time in the lapTimes list.
                // Console.WriteLine("Enter another Lap time: ");
            }
            else // If the users Input was invalid, for example not a number, this runs. 
            {
                Console.WriteLine("Invalid input. Please enter an appropriate Lap Time in seconds");
            }
        }
        // After exiting the loop, check that lap times were entered.
        if (lapTimes.Count > 0)
        {
            lapTimes.Sort(); // Here I sort the lap times in the list from fastest time to slowest.

            double AvgTime = Average(lapTimes); // Here I call the average() method to calculate the mean lap time.

            Console.WriteLine($"Number of Laps: {lapTimes.Count}"); // Here I display how many lap times were entered.
            Console.WriteLine($"Average Lap Times: {AvgTime}"); // Here I display the average lap time.
            
            // Here I display all lap times entered from fastest to slowest. 
            foreach (double time in lapTimes)
            {
                Console.WriteLine($"{time:F2} Seconds");
            }
        }
        else // This runs if no lap times were entered at all.
        {
            Console.WriteLine("No lap times were entered");
        }
    }
    public static double Average(List<double> lapTimes) // This function calculates the average using the lap times from the lapTimes list.
    {
        double total = 0; // Here I store the total of all lap times added together. 
        foreach (double t in lapTimes) // Loop through and add each lap time to the "total" variable
        {
            total += t;
        }
        return total / lapTimes.Count; // Divide the total by how many lap times there are to get the average.

    }


    public static void WarmUp2() // This is a student register system which allows to enter their Student IDs one by one.
    {
        HashSet<int> set = new HashSet<int>(); // Create a HashSet to store unique student IDs (No duplicates allowed)

        Console.WriteLine("Student Register System");
        Console.WriteLine("Enter Student IDs (enter 0 to finish)");

        while (true)
        {
            Console.Write("Enter Student ID: "); // User types the student ID here.
            string input = Console.ReadLine(); // Read the Users input as text.


        }
    }
}