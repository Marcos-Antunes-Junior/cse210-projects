using System;

public class Exercises
{
    private string _name;
    private string _description;

    public Exercises(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public virtual void StartExercise(int reps, int sets, int restTime){}

    public virtual void AddNewExercise(){}

    public virtual void ClearCurrentConsoleLine(){}

    public virtual void LevelChoice(){}

    public virtual void SaveInfoFile(){}

    public virtual void ReadFile(){}

    public virtual void DisplayExercisesList(){}

    public virtual void CountingLoading(int restTime){}
}