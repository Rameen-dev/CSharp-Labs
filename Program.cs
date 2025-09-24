// Import the namespace where your exercise lives.
using CSharpLab;
using System.Runtime.CompilerServices;

// Main entry point of the program 
while (true) // Loop forever until the user chooses "Exit"
{
    // Display the menu options
    Console.WriteLine("\n=== C# Labs ===");   // Menu Title


    Console.WriteLine("1) Variables");        // Option 1
    Console.WriteLine("0) Exit");             // Exit Program

    Console.WriteLine("Week 1");

    Console.Write("Choices: ");

    var c = Console.ReadLine(); // Read user input

    switch (c)
    {
        case "1":
            Variables.Run();
            break;
        case "Week 1":
            Week1_WarmUp.WarmUp1(); 
            break;

        case "0":
            return;
    }    

}
