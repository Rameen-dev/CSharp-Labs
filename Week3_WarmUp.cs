using System;
using System.Collections.Generic;
using System.Linq;

public static class Week3_WarmUp
{
    public static void Run()
    {
        Console.WriteLine("Week 3 Warm up Tasks is running!");
    }

    public static void WarmUp1()
    {
        List<int> numbers = new List<int> { 2, 3, 4, 5, 6, 7, 8, 9 }; // List of numbers.

        int smallNumber = numbers.Min(); // Using the Min function to fetch the smallest number from the "numbers" list.
        int largeNumber = numbers.Max(); // Using the Max function to fetch the largest number from the "numbers" list.
        
        // Below I output and display the Min and Max number from the "numbers" list.
        Console.WriteLine($"The smallest number in the list is: {smallNumber}\n"); 
        Console.WriteLine($"The largest number in the list is: {largeNumber}");
    }

    public static void WarmUp2()
    {
        // Create a list of words (collection) - Each word is a string.
        List<string> words = new List<string>
        {
            "Dog",
            "Cat",
            "Donut",
            "Airplane",
            "Animal",
        };
        // Here I use the Where() to filter through the list
        // Take each word, and return true if its length is less than or equal to 5 characters.
        IEnumerable<string> shortwords = words.Where(word => word.Length  <= 5); // The lambda function returns TRUE or FALSE for each item.

        // Below is just a clean simple way of looping through the words in the collection, and listing them in a neat manner.
        Console.WriteLine("Words shorter than 5 characters:\n ");

        int count = 1;
        foreach (string word in shortwords)
        {
            Console.WriteLine($"{count}. " + word + " - " + word.Length + " Characters long");
            count++;
        }
        Console.ReadLine();
    }
}
