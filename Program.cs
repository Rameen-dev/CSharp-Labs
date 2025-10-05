// Import the namespace where your exercise lives.
using CSharpLab;
using System.Runtime.CompilerServices;

// Main entry point of the program 
while (true) // Loop forever until the user chooses "Exit"
{
    // Display the menu options
    Console.WriteLine("\n=== C# Labs ===");   // Menu Title
    Console.WriteLine("1) Variables");        // Option 1
    // Week 1 Worksheet
    Console.WriteLine("Week 1) - Warm Up Tasks"); // Beginner Task worksheet
    Console.WriteLine("Week 1) - Essential Tasks"); // Essential Task worksheet
    Console.WriteLine("Week 1) - Tougher Tasks"); // Tougher Task worksheet



    Console.WriteLine("0) Exit");             // Exit Program

    // Enter name of worksheet you want to access.
    Console.Write("Choices: ");

    var c = Console.ReadLine(); // Read user input
    c = c.Trim().ToLower(); // Trim and Lower input.

    switch (c)
    {
        case "variables":
            Variables.RunVariables();
            break;

        case "week 1 - Warm-up":
            Week1_WarmUp.WarmUp2(); 
            break;

        case "week 1 - Essential":
            Week1_Essential.Essential6(); 
            break;

        case "Week 1 - Tougher": // File not created yet for this switch case.
            //Week1_Tougher.Run();
            return;

        case "exit":
            return;
    }   
}
