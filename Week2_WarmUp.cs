using CSharpLab;
using System.ComponentModel.Design;
using System.Runtime.InteropServices;
using System.Collections.Generic; 


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
        HashSet<int> studentIDs = new HashSet<int>(); // Create a HashSet to store unique student IDs (No duplicates allowed) - Type of collection that's a data structure.

        Console.WriteLine("Student Register System"); 
        Console.WriteLine("Enter Student IDs (enter 0 to finish)");

        while (true)
        {
            Console.Write("Enter Student ID: "); // User types the student ID here.
            string input = Console.ReadLine(); // Read the Users input as text.

            // TryParse returns true if the conversion is successful.
            if (int.TryParse(input, out int id)) // Here I Convert the users input from a string to a Integer (Number)
            {
                if (id == 0) // End the Infinite loop if the user enters 0, indicating the end of the program.
                {
                    Console.WriteLine("Ended from 0 Input"); break; // Exit the while loop
                }
                if (studentIDs.Add(id)) // If input is valid, we add the new Unique student ID to the Hash set.
                {
                    Console.WriteLine($"Student ID: {id} has been added Successfully!"); // Display message indicating the successful addition of the new Student ID to the collection.
                }
                else // If the entered student ID is a duplicate, it won't be added and this message will be displayed.
                {
                    Console.WriteLine($"Student ID: {id} is already registered in the System."); 
                }
            }
            else // If Input was invalid (Letters in input) then I display this message to the user.
            {
                Console.WriteLine("Please enter a valid Student ID to Register!");
            }
        }
        Console.WriteLine($"Total student IDs: {studentIDs.Count()}"); // Here I display the Total count of all student IDs in the system.
        Console.WriteLine("List of Registered Students"); // Here I show the list of Student IDs below through the foreach statement.

        int count = 1; // Start a counter from 1 to label each student in order.

        foreach (int id in studentIDs) // Loop through every id in studentIDs in the HashSet.
        {
            Console.WriteLine($"Student {count}.) {id}"); // Display the student ID in a readable format.
            count++; // Increase the counter by 1 for the next student.
        }
        Console.WriteLine("End of Student Register.");
    }
    public static void WarmUp3() 
        {
        // I created a Dictionary here where: Key = Patients Name, Value = NHS Number.
        Dictionary<string, int> patients = new Dictionary<string, int>();

        // Here I hardcoded and store the patients Name and NHS Number.
        patients.Add("Rameen Burdabar", 4010606);
        patients.Add("Bogdan Dinulescu", 4023190);
        patients.Add("Osama Elamami", 4021765);
        patients.Add("Reefat Daniel Aziz", 4011068);

        // Simple UI Header
        Console.WriteLine("Patient NHS Look-up - Patient Names");
        Console.WriteLine("-------------------------------------");
        Console.WriteLine("Enter a patients Full name to view their NHS Number.");
        Console.WriteLine("Type 'Exit' to end program.");

        // Here I keep asking for names until the user types "Exit"
        while (true)
        {
            Console.Write("Enter patient Name: ");
            string input = Console.ReadLine(); // Read the users input.

            if (string.IsNullOrEmpty(input)) // If Input was left empty then I display this message to the user.
            {
                Console.WriteLine("Invalid Input, please try again!");
                continue;
            }
            if (input == "Exit")
            {
                Console.WriteLine("Program ended!");
                break;
            }
            if (patients.ContainsKey(input))
            {
                Console.WriteLine($"\nNHS Number for patient {input}: {patients[input]}");
            }
            else
            {
                Console.WriteLine("Patient does not Exist in Dictionary");
            }
           
            Console.WriteLine("All NHS Patient Details\n");
            int count = 1;
            foreach (KeyValuePair<string, int> record in patients)
            {
                Console.WriteLine($"Patient {count}.) Name: {record.Key} - NHS Number: {record.Value}");
                count++;
            }
        }
        Console.WriteLine("End of NHS System");
    }
}