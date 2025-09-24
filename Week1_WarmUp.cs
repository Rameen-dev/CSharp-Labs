using CSharpLab;
using System.ComponentModel.Design;
using System.Net.Cache;

public static class Week1_WarmUp
{
    public static void Run()
    {
        Console.WriteLine("Week 1 is running");
    }

    // Warm up Task 1
    public static void WarmUp1() 
    {
        Console.Write("Enter the first number for the Clamp function: "); // Here I ask for the first number for Clamp
        int value = ReadIntUserInput();

        Console.Write("Enter the second number for the Clamp function: "); // Here I ask for the second number for Clamp
        int min = ReadIntUserInput();

        Console.Write("Enter the third number for the Clamp function: "); // Here I ask for the third number for Clamp
        int max = ReadIntUserInput();

        int result = Clamp(value, min, max); // Here I take all the inputs required for clamp.

        Console.WriteLine($"Clamped result is: {result}"); // Output Clamp result

    }
    private static int Clamp(int value, int min, int max) // Clamp function takes place here.
    {
        if (value < min)
            return min;

        if (value > max)
            return max;

        return value;
    }
    private static int ReadIntUserInput() // Here I have check to ensure only Integers are being input.
    {
        while (true)
        {
            string? input = Console.ReadLine();
            if (int.TryParse(input, out int number)) // A fail-safe that checks the user Input is an Integer. 
                return number;

            Console.WriteLine("Please enter a valid number");
        }
    }

    // Warm up Task 2

    public static void WarmUp2()
    {
        Console.Write("Please enter a name: "); // Here I take person1 Name
        string name1 = ReadStringUserInput(); // I store it under name1 Variable

        Console.Write("Please enter a age: "); // Here I take person1 Age
        int age1 = ReadIntUserInput(); // I store it under age1 Variable
        var person1 = new Person(name1, age1); // This is Second person Object

        Console.Write("Please enter another name: "); // Here I take the person2 Name
        string name2 = ReadStringUserInput(); // I store it under name2 Variable

        Console.Write("Please enter another age: "); // Here I take the person2 Age
        int age2 = ReadIntUserInput(); // I store it under age2 Variable
        var person2 = new Person(name2, age2); // This is my Second person Object

        // Here I display both objects separately
        person1.DisplayPersonInfo(); 
        person2.DisplayPersonInfo();
    }
    private static string ReadStringUserInput() // Here I have check to ensure only Alphabet characters are being input.
    {
        while (true)
        {
            string? input = Console.ReadLine();
            if (string.IsNullOrEmpty(input))
            {
                continue;
            }
            bool hasNumber = input.Any(char.IsDigit);
            if (!hasNumber)
            {
                return input;
            }
            else
            {
                Console.WriteLine($"Please enter a valid name {hasNumber}");
            }
            
        }
    }

    // This is my person class
    public class Person
    {
        public string Name { get; set; } // This is a property for Name - It stores string text that represents a person's name.
        public int Age { get; set; } // This is a property for Age - It stores int numbers that represents a person's age.
        public Person(string name, int age) // This is a constructor which runs when I make a new person object. 
        {
            // The "Name" property on the left refers to the property defined above.
            Name = name; // The "name" lowercase is the parameter passed in when creating a person.

            // The "Age" property on the left refers to the property defined above. 
            Age = age; // The "age" lowercase is the parameter passed in when creating a person
        }

        // This is a method (function) inside the class which displays the person details.
        public void DisplayPersonInfo()
        { 
        Console.WriteLine($"Name: {Name}, Age: {Age}"); // Here I display both the person details that I have stored in my Person class
        }
    }
}




