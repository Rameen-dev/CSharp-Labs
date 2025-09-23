
namespace CSharpLab;

public static class Variables
{
    public static void Run()
    {
        Console.WriteLine("Variables Practice");

        // Integer (Whole Number)

        int age = 17;
        Console.WriteLine($"Your age is {age}");

        // Update the value of the variable 

        age = age + 1;
        Console.WriteLine($"Next year you will be {age}");

        // Double (Decimal number)

        double price = 19.99;
        Console.WriteLine($"The total cost of 1 Item is {price}");

        // Do a calculation with double values
        double total = price * 3;
        Console.WriteLine($"The total cost for 3 Items is {total}");

        // String (Text)

        string name = "Rameen";
        Console.WriteLine($"My name is {name}");
    }
}
