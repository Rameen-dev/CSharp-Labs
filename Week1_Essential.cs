using CSharpLab;

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
}