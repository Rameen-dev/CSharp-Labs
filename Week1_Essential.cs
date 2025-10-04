using CSharpLab;
using System.ComponentModel.Design;
using System.Diagnostics.Metrics;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using static System.Runtime.InteropServices.JavaScript.JSType;

public static class Week1_Essential
{
    public static void Run()
    {
        Console.WriteLine("Week 1 Essential Tasks is running");
    }
    // Essential Task 1
    public static void Essential1()
    {
        Console.WriteLine("Enter what you are currently doing (e.g. Sleeping, Eating, Working out.): ");
        
        string? currentActivity = Console.ReadLine();
        currentActivity = currentActivity.ToLower().Trim();

        string nextTask = WhatIsNext(currentActivity);

        Console.WriteLine($"Next you should {nextTask}");
    }
    public static string WhatIsNext(string currentActivity)
    {
        string[] tasks = { "wake up", "make bed", "shower", "brush teeth", "wear contact lenses", "wear clothes", "facial cream", "pack for university", "workout" };

        int index = Array.IndexOf(tasks, currentActivity); // Array.IndexOf() finds the position of the current task in the Array.

        if (index != -1) // This ensures the task was actually found.
        {
            int nextIndex = (index + 1) % tasks.Length; // That number after % will always be tasks.Length (the size of your list).

            return tasks[nextIndex]; // The next task will be given here. 
        }
        else
        {
            return "Task not found"; // This will occur if there is an Invalid task.
        }
    }

    // Essential Task 2
    public static void Essential2()
    {
        var imperial = GetHeightFromUser(); 
        // This calls my first function which asks for the height of a user in Feet and Inches.
        // It uses those numbers to create a new ImperialHeights Object
        // That object is then stored under the imperial variable defined above.
        // Imperial now contains the feet and inches from the users input.

        imperial.DisplayImperialHeight();
        // This calls method inside the class DisplayImperialHeight() on your object (imperial)
        // This prints the value in the object (feet, inches)

        float metres = ConvertToMetres(imperial);
        // This calls my second function ConvertToMetres() and passes in the object "imperial" as a parameter.
        // Inside the function we convert feet to inches and then convert the total inches to metres and return it.
        // I return a float (the height in metres)
        // That float is saved in the variable (metres) - Example: 5(feet) * 12 = 60 + 10(inches = 70 Inches. Convert Inches to metres: 70(Total Inches) * 0.0254 = 1.778 Metres.

        DisplayMetres(metres);
        // This calls the third function DisplayMetres()
        // Passes the metres float as a parameter 
        // Inside the function we do metres:F2 for an output of metres to two decimal places.


    }
    // This is the first function to Task 2 - Getting Height from user in Feet and Inches.
    public static ImperialHeights GetHeightFromUser()
    {
        Console.Write("Enter your height (feet): "); // Ask for the users height via feet.
        int feet = Convert.ToInt32(Console.ReadLine()); // Convert the text input into a whole number (Integer).

        Console.Write("Enter your height (Inches): "); // Ask for the users height via inches.
        int inches = Convert.ToInt32(Console.ReadLine()); // Convert the text input into a whole number (Integer).

        return new ImperialHeights(feet, inches);
    }
    // This function displays the height in metres to two decimal places.
    public static void DisplayMetres(float metres)
    {
        Console.WriteLine($"Imperial Height in metres: {metres:F2}");
    }
    // This function converts the Imperial height (feet, inches) to metres. 
    public static float ConvertToMetres(ImperialHeights height)
    {
        int totalInches = (height.Feet * 12) + height.Inches;
        float metres = totalInches * 0.0254f;
        return metres;
    }
    // This is the class that stores two Integers for the Imperial Height.
    public class ImperialHeights
    {
        public int Feet {  get; set; } // This is the feet property
        public int Inches { get; set; } // This is the Inches property
        public ImperialHeights(int feet, int inches) // This is a constructor. It runs automatically when you do "new ImperialHeights(feet, inches)".
        {
            // It sets the Feet and Inches properties to the values you pass in.
            Feet = feet;
            Inches = inches;
        }
        // This function displays the users Imperial Height in Feet and Inches.
        public void DisplayImperialHeight()
        {
            Console.WriteLine($"Imperial Height in\n Feet: {Feet}\n Inches: {Inches}");
        }
    }

    // Essential Task 3 
    public static void Essential3() // This function receives an input and outputs the count of Capital letters, lowercase letters, numbers, whitespaces and symbols.
    {
        Console.Write("\nEnter a string: "); // User enters the string here.
        string input = Console.ReadLine();

        if (string.IsNullOrEmpty(input)) // Check to ensure the input was valid (Not null)
        {
            Console.WriteLine("You must enter some text!");
            return;
        }
        // Below I track the count of each of the type of inputs (e.g, Capital letters, lowercase letters, numbers, whitespace)
        int isUpper = 0; 
        int isLower = 0;
        int isDigit = 0;
        int isSymbol = 0;
        int isWhiteSpace = 0;

        // Loop through each character in the 'input' string
        for (int i = 0; i < input.Length; i++) 
        {
            char c = input[i]; // Fetch the character at position [i]

            // Here I check the character type and increment the right counter.
            if (char.IsUpper(c)) // If it's a capital letter, increment the isUpper count by one.
            {
                isUpper++;        
            }
            else if (char.IsLower(c)) // Else if it's a lowercase letter, increment the isLower count by one.
            {
                isLower++;
            }
            else if (char.IsDigit(c)) // Else if it's a digit, increment the isDigit count by one.
            {
                isDigit++;
            }
            else if (char.IsWhiteSpace(c)) // Else if it's whitespace, increment the isWhiteSpace count by one.
            {
                isWhiteSpace++;
            }
            else // If it's none of the above it must be a symbol, increment the isSymbol count by one.
            {
                isSymbol++;
            }
        }

        // Display input string for reference with length of string
        Console.WriteLine($"String:{input}");
        Console.WriteLine($"Length of String:{input.Length}\n");

        // Here I display the results back to the user
        Console.WriteLine($"Count of Capital letters in string:\n{isUpper}");
        Console.WriteLine($"Count of Lowercase letters in string:\n{isLower}");
        Console.WriteLine($"Count of Numbers in string:\n{isDigit}");
        Console.WriteLine($"Count of Symbols in string:\n{isSymbol}");
        Console.WriteLine($"Count of Whitespace in string:\n{isWhiteSpace}");
    }

    // Essential Task 4 
    public static void Essential4() // This function creates a multiplication grid for numbers between 1 and 12
    {
        for (int row = 1; row <= 12; row++) // Outer Loop: Goes through each Column from 1 to 12
        {
            for (int col = 1; col <= 12; col++) // Inner Loop: Goes through each Column from 1 to 12
            {
                int product = row * col; // Multiply the current row and column numbers to get the product 
                Console.Write($"{ product,4}"); // Here I print the product 
            }
            Console.WriteLine();
        }
    }
    public static void Essential4_Practice()
    {
        for (int row = 1; row <=5;  row++)
        {
            for (int col =1; col <= row; col++)
            {
                int product = row * col;
                Console.Write(col + "",3);
            }
            Console.WriteLine();
        }
    }
    // Essential Task 5
    public static void Essential5() // This function prints the total count of numbers that contain a 2 or a 7 between the range 0 - 1,000,000
    {
        int count67 = 0; // Here I will store the count of total numbers that either contain a 2 or a 7.
        for (int i = 0; i <= 1000000; i++) // Here I form the range.
        {
            string s = i.ToString(); // Convert the int range into string format.

            if (s.Contains('2') || (s.Contains('7')))
            {
                count67++;
            }
        }
        Console.WriteLine(count67); // Display the output of total numbers that contain 2 or 7
    }


    // Essential Task 6

    public static void Essential6()
    {
        while (true)
        {

            List<float> list = new List<float>(); // Here I create an empty list that holds float values.

            string Input1; // Here I store the users Raw input.
            float inputF; // I will store the converted Raw input into a float data-type and store it here.

            while (true) // This loop checks to make sure that the user is entering a valid number.
            {
                Console.Write("Please enter a valid number: ");
                Input1 = Console.ReadLine();

                if (string.IsNullOrEmpty(Input1))
                {
                    Console.WriteLine("You must enter a valid number! Try again.");
                    continue; // Restart the loop if input is invalid.
                }

                if (float.TryParse(Input1, out inputF))
                {
                    break; // If input passes and converts to a float data-type, break out of the loop and carry on.
                }
                else
                {
                    Console.WriteLine("That wasn't a valid number. Please try again.");
                }
            }

            while (inputF != 0) // Here I keep asking for numbers until the user enters a 0. 
            {
                list.Add(inputF); // Every other number gets added to the list established earlier 'list'.
                Console.Write("Please enter another number: ");
                string input2 = Console.ReadLine();
                inputF = Convert.ToSingle(input2);
            }
            if (list.Count < 2) // Another safety check to ensure the list is not empty when performing calculations.
            {
                Console.WriteLine("You need to enter at least two valid numbers first");
                continue;
            }
            else
            {
                Console.WriteLine("List count: " + list.Count);
                Console.WriteLine("List Average: " + list.Average());
                Console.WriteLine("List Min: " + list.Min());
                Console.WriteLine("List Max: " + list.Max());
            }
        }
    }
}