using System;

public class Goal
{   
    private string _name;
    private string _description;
    private int _points;
    private bool _completed;
    private int _bonus;

      public Goal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
    }
    
    public virtual void NewGoal(){}
   
    public virtual void Completed(){}
    
    public virtual int GetTimesCompleted()
    {
        return 0;
    }

    public virtual int GetCountRequired()
    {
        return 0;
    }
    
    public virtual int GetBonus()
    {
        return 0;
    }
    
    public virtual void SetBonus(int bonus)
    {
        _bonus = bonus;
    }
   
    public string GetName()
    {
        return _name;
    }

    public void SetName(string name)
    {
        _name = name;
    }

    public string GetDescription()
    {
        return _description;
    }

    public void SetDescription(string description)
    {
        _description = description;
    }

    public int GetPoints()
    {
        return _points;
    }

    public void SetCompleted(bool completed)
    {
        _completed = completed;
    }

    public bool GetCompleted()
    {
        return _completed;
    }

    public void SetPoints(int points)
    {
        _points = points;
    }
}

