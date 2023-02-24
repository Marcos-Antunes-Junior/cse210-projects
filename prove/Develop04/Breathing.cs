using System;

public class Breathing : Activity
{
    public Breathing(string activityName, string activityDescription, string finishingMessage) : base(activityName, activityDescription, finishingMessage)
    {
        activityName = "";
        activityDescription = "";
        finishingMessage = "";
    }

    public void StartActivity()
    {
        Console.WriteLine("");
        Console.Write("Breathe in...");
        Console.Write("5");
        Thread.Sleep(1000);
        Console.Write("\b \b");
        Console.Write("4");
        Thread.Sleep(1000);
        Console.Write("\b \b");
        Console.Write("3");
        Thread.Sleep(1000);
        Console.Write("\b \b");
        Console.Write("2");
        Thread.Sleep(1000);
        Console.Write("\b \b");
        Console.Write("1");
        Thread.Sleep(1000);
        Console.Write("\b \b");
        Console.WriteLine("");
        Console.Write("Now breathe out...");
        Console.Write("6");
        Thread.Sleep(1000);
        Console.Write("\b \b");
        Console.Write("5");
        Thread.Sleep(1000);
        Console.Write("\b \b");
        Console.Write("4");
        Thread.Sleep(1000);
        Console.Write("\b \b");
        Console.Write("3");
        Thread.Sleep(1000);
        Console.Write("\b \b");
        Console.Write("2");
        Thread.Sleep(1000);
        Console.Write("\b \b");
        Console.Write("1");
        Thread.Sleep(1000);
        Console.Write("\b \b");
        Console.WriteLine("");
    }
}