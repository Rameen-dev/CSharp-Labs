using CSharpLab;

public static class Week1_WarmUp
{
    public static void Run()
    {
        Console.WriteLine("Week 1 is running");
    }
    public static void WarmUp1()
    {
        Console.Write("Enter the first number for the Clamp function: ");
        int value = ReadIntUserInput();

        Console.Write("Enter the second number for the Clamp function: ");
        int min = ReadIntUserInput();

        Console.Write("Enter the third number for the Clamp function: ");
        int max = ReadIntUserInput();

        int result = Clamp(value, min, max);

        Console.WriteLine($"Clamped result is: {result}");

    }

    private static int Clamp(int value, int min, int max)
    {
        if (value < min)
            return min;

        if (value > max)
            return max;

        return value;
    }
        

    private static int ReadIntUserInput()
    {
        while (true)
        {
            string? input = Console.ReadLine();
            if (int.TryParse(input, out int number))
                return number;

            Console.WriteLine("Please enter a valid number");
        }
    }
}
  


   
