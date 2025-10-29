// Import the namespace where your exercise lives.
using CSharpLab;
using System.Runtime.CompilerServices;

// Main entry point of the program 
while (true) // Loop forever until the user chooses "Exit"
{
    // Display the menu options
    Console.WriteLine("\n=== C# Labs ===");   // Menu Title
    Console.WriteLine("1) Variables\n");        // Option 1
    // Week 1 Worksheet
    Console.WriteLine("Week 1) - Warm Up Tasks: week 1 - warm-up"); // Beginner Task worksheet
    Console.WriteLine("Week 1) - Essential Tasks: week 1 - essential"); // Essential Task worksheet
    Console.WriteLine("Week 1) - Tougher Tasks: Week 1 - tougher\n"); // Tougher Task worksheet
    // Week 2 Worksheet
    Console.WriteLine("Week 2) - Warm Up Tasks: week 2 - warm-up"); // Beginner Task worksheet
    Console.WriteLine("Week 2) - Essential Tasks: Coming Soon"); // Essential Task worksheet
    Console.WriteLine("Week 2) - Tougher Tasks: Coming Soon\n"); // Tougher Task worksheet
    // Week 3 Worksheet
    Console.WriteLine("Week 3) - Warm Up Tasks: week 3 - warm-up");


    Console.WriteLine("Exit: exit\n");             // Exit Program

    // Enter name of worksheet you want to access.
    Console.Write("Choices: ");

    var c = Console.ReadLine(); // Read user input
    c = c.Trim().ToLower(); // Trim and Lower input.

    switch (c)
    {
        case "variables":
            Variables.RunVariables();
            break;

        case "week 1 - warm-up":
            Week1_WarmUp.WarmUp2(); 
            break;

        case "week 1 - essential":
            Week1_Essential.Essential7(); 
            return;

        case "Week 1 - tougher": // File not created yet for this switch case.
            //Week1_Tougher.Run();
            return;

        case "week 2 - warm-up":
            Week2_WarmUp.WarmUp5();
            return;

        case "week 3 - warm-up":
            Week3_WarmUp.WarmUp2();
            return;

        case "exit":
            return;
    }   
}
