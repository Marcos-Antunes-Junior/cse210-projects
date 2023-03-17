using System;

public class ChecklistGoal : Goal
{
   private int _countRequired;
   private int _bonus;
   private int _timesCompleted;

   public ChecklistGoal(string name, string description, int points, int countRequired, int timesCompleted, int bonus) : base (name, description, points)
    {
        SetName(name);
        SetDescription(description);
        SetPoints(points);
        SetCountRequired(countRequired);
        SetTimesCompleted(timesCompleted);
        SetBonus(bonus);
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
        Console.Write("How many times does this goal need to be accomplished for a bonus?: ");
        int timesCompleted = int.Parse(Console.ReadLine());
        SetTimesCompleted(timesCompleted);
        Console.Write("What is the bonus for accomplishing it that many times?: ");
        int bonus = int.Parse(Console.ReadLine());
        SetBonus(bonus);
    }

    public void SetTimesCompleted(int timesCompleted)
    {
        _timesCompleted = timesCompleted;
    }

    public override int GetTimesCompleted()
    {
        return _timesCompleted;
    }

    public void SetCountRequired(int countRequired)
    {
        _countRequired = countRequired;
    }

    public override int GetCountRequired()
    {
        return _countRequired;
    }

    public override void SetBonus(int bonus)
    {
        _bonus= bonus;
    }

    public override int GetBonus()
    {
        return _bonus;
    }

    public override void Completed()
    {
        _countRequired ++;
        Console.WriteLine($"Congratulations! You have earned {GetPoints()} points.");
        if (_countRequired == _timesCompleted)
        {
            Console.WriteLine($"Congratulations! You have earned {GetBonus()} bonus points.");   
        }
    }
}