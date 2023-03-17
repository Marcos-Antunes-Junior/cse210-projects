using System;

public class SimpleGoal : Goal 
{
  
  public SimpleGoal(string name, string description, int points, bool completed) : base(name, description, points)
    {
        SetName(name);
        SetDescription(description);
        SetPoints(points);
        SetCompleted(completed);
    }

    public override void NewGoal()
    {
        Console.Write("What is the name of your goal?: ");
        string name = Console.ReadLine();
        SetName(name);
        Console.Write("What is a short description of it?: ");
        string description = Console.ReadLine();
        SetDescription(description);
        Console.Write("What is the ammount of points associated with this goal?: ");
        int points = int.Parse(Console.ReadLine());
        SetPoints(points);
        SetCompleted(false);
    }

    public override void Completed()
    {
        Console.WriteLine($"Congratulations! You have earned {GetPoints()} points.");
        SetCompleted(true);
    }
}