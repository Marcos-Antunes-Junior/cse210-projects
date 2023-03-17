using System;

public class DisplayGoals
{
    private int _totalPoints = 0;
    private string _filename;

    public void ListGoals(List<Goal> goals)
    {

        Console.WriteLine("The Goals are:");
        foreach (Goal goal in goals)
        {
            string check = "[ ]";

            if (goal is SimpleGoal)
            {
                if (goal.GetCompleted())
                {
                    check = "[X]";
                }
                Console.WriteLine($"{goals.IndexOf(goal) + 1}. {check} {goal.GetName()} ({goal.GetDescription()})");
            }
            else if (goal is EternalGoal)
            {
                Console.WriteLine($"{goals.IndexOf(goal) + 1}. {check} {goal.GetName()} ({goal.GetDescription()})");
            }
            else if (goal is ChecklistGoal)
            {
                if (goal.GetCountRequired() == goal.GetTimesCompleted())
                {
                    check = "[X]";
                }
                Console.WriteLine($"{goals.IndexOf(goal) + 1}. {check} {goal.GetName()} ({goal.GetDescription()}) -- Currently Completed: {goal.GetCountRequired()}/{goal.GetTimesCompleted()}");
            }
        }
    }

    public void SaveGoals(List<Goal> goals, string filename)
    {
        _filename = filename;

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine($"{_totalPoints}");
            foreach (Goal goal in goals)
            {
                if (goal is SimpleGoal)
                {
                    outputFile.WriteLine($"SimpleGoal:{goal.GetName()},{goal.GetDescription()},{goal.GetPoints()},{goal.GetCompleted()}");
                }
                else if (goal is EternalGoal)
                {
                    outputFile.WriteLine($"EternalGoal:{goal.GetName()},{goal.GetDescription()},{goal.GetPoints()}");
                }
                else if (goal is ChecklistGoal)
                {
                    outputFile.WriteLine($"ChecklistGoal:{goal.GetName()},{goal.GetDescription()},{goal.GetPoints()},{goal.GetCountRequired()},{goal.GetTimesCompleted()},{goal.GetBonus()}");
                }
            }
        }
    }

    public List<Goal> LoadGoals(List<Goal> goals, string filename)
    {
        _filename = filename;
        string[] lines = System.IO.File.ReadAllLines(filename);
        _totalPoints = int.Parse(lines[0]);
        lines = lines.Skip(1).ToArray();
        goals.Clear();
        foreach (string line in lines)
        {
            string[] parts = line.Split(":");
            string name = parts[0];
            string goal = parts[1];

            if (name == "SimpleGoal")
            {
                string[] part = goal.Split(",");
                SimpleGoal simple = new SimpleGoal(part[0], part[1], int.Parse(part[2]), bool.Parse(part[3]));
                goals.Add(simple);
            }
            else if (name == "EternalGoal")
            {
                string[] part = goal.Split(",");
                EternalGoal eternal = new EternalGoal(part[0], part[1], int.Parse(part[2]));
                goals.Add(eternal);
            }
            else if (name == "ChecklistGoal")
            {
                string[] part = goal.Split(",");
                ChecklistGoal checklist = new ChecklistGoal(part[0], part[1], int.Parse(part[2]), int.Parse(part[3]), int.Parse(part[4]), int.Parse(part[5]));
                goals.Add(checklist);
            }
        }
        return goals;
    }

    public void RecordEvent(List<Goal> goals)
    {
        Console.WriteLine("The goals are: ");
        foreach (Goal goal in goals)
        {
            Console.WriteLine($"{goals.IndexOf(goal) + 1}. {goal.GetName()}");
        }
        Console.Write("Which goal did you accomplish?: ");
        int goalNumber = int.Parse(Console.ReadLine()) - 1;
        goals[goalNumber].Completed();
        if (goals[goalNumber] is ChecklistGoal && goals[goalNumber].GetCountRequired() == goals[goalNumber].GetTimesCompleted())
        {
            _totalPoints += (goals[goalNumber].GetPoints() + goals[goalNumber].GetBonus());
        }
        else
        {
            _totalPoints += goals[goalNumber].GetPoints();
        }
    }

    public int DisplayTotalPoints()
    {
        return _totalPoints;
    }
}