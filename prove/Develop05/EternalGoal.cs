using System;

public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) : base (name, description, points)
    {
        SetName(name);
        SetDescription(description);
        SetPoints(points);
    }

    public override void NewGoal()
    {
        Console.Write("Which is the name of your goal?: ");
        string name = Console.ReadLine();
        SetName(name);
        Console.Write("What is a short description of it?: ");
        string description = Console.ReadLine();
        SetDescription(description);
        Console.Write("What is the ammount of points associated with this goal?: ");
        int points = int.Parse(Console.ReadLine());
        SetPoints(points);
    }

    public override void Completed()
    {
        Console.WriteLine($"Congratulations! You have earned {GetPoints()} points.");
        SetCompleted(true);
    }
}