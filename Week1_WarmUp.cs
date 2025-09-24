using CSharpLab;

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
    private static int ReadIntUserInput() // Here I am reading the user inputs. 
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
    }
}
  


   
