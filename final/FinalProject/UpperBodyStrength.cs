using System;

public class UpperBodyStrength : Exercises
{
    private string _name;
    private string _description;
    private List<string> _upperStrength = new List<string>();

    public UpperBodyStrength(string name, string description) : base(name, description)
    {
        _name = name;
        _description = description;
    }

    public override void ReadFile()
    {
        string filename = "upper_strength.txt";
        string[] lines = System.IO.File.ReadAllLines(filename);
        foreach (string line in lines)
        {
            string[] parts = line.Split(".|");
            string firstName = parts[0];
            _upperStrength.Add(firstName);
        }
    }

    public override void SaveInfoFile()
    {
        string filename = "upper_strength.txt";
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            for (int i = 0; i < _upperStrength.Count; i++)
            {
                outputFile.WriteLine($"{_upperStrength[i]}.|");
            }
        }
    }

    public override void CountingLoading(int restTime)
    {
        for (int i = restTime; i > 0; i--)
        {
            Console.Write("\b \b");
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

    public override void StartExercise(int reps, int sets, int restTime)
    {
        for (int i = 0; i < _upperStrength.Count; i++)
        {
            Console.Clear();
            Console.WriteLine($"Number of exercises: {_upperStrength.Count}/{i + 1}");
            Console.WriteLine(_upperStrength[i]);
            string userInput;
            Console.WriteLine("");
            Console.WriteLine("If you feel very tired, you can decrease the repetitions and increase the rest time.");
            Console.WriteLine("");
            Console.WriteLine($"Number of reps: {reps}");
            Console.WriteLine($"Number of sets: {sets}");
            Console.WriteLine("");
            int numOfSets = sets;
            do
            {
                Console.Write($"Remaining sets: {numOfSets--} --- Press Enter after completing the exercise to continue:");
                userInput = Console.ReadLine();
                Console.SetCursorPosition(0, Console.CursorTop - 1);
                ClearCurrentConsoleLine();
                if (numOfSets == 0)
                {
                    Console.Clear();
                    Console.WriteLine("Rest time!");
                    CountingLoading(restTime);
                }
                else if (numOfSets != 0)
                {
                    Console.WriteLine("Take a rest and prepare for the next rep!");
                    CountingLoading(restTime);
                    Console.SetCursorPosition(0, Console.CursorTop - 1);
                    ClearCurrentConsoleLine();
                }
            }
            while(numOfSets != 0);
        }
    }

    public override void ClearCurrentConsoleLine()
    {
        int currentLineCursor = Console.CursorTop;
        Console.SetCursorPosition(0, Console.CursorTop);
        Console.Write(new string(' ', Console.WindowWidth));
        Console.SetCursorPosition(0, currentLineCursor);
    }

    public override void LevelChoice()
    {
        ReadFile();
        Console.Clear();
        string userInput;
        Console.WriteLine("Please, choose the difficulty level: ");
        Console.WriteLine("1. Beginner");
        Console.WriteLine("2. Intermediate");
        Console.WriteLine("3. Advanced");
        Console.Write("Please, select an option: ");
        userInput = Console.ReadLine();
        if (userInput == "1")
        {
            int reps = 8;
            int sets = 3;
            int restTime = 40;
            StartExercise(reps, sets, restTime);
        }
        else if (userInput == "2")
        {
            int reps = 10;
            int sets = 4;
            int restTime = 30;
            StartExercise(reps, sets, restTime);
        }
        else if (userInput == "3")
        {
            int reps = 15;
            int sets = 4;
            int restTime = 20;
            StartExercise(reps, sets, restTime);
        }
    }

    public override void DisplayExercisesList()
    {
        for (int i = 0; i < _upperStrength.Count; i++)
        {
            Console.WriteLine(_upperStrength[i]);
            Console.WriteLine("");
        }
    }

    public override void AddNewExercise()
    {
        string exercise = $"NAME: {_name} -- DESCRIPTION: {_description}";
        _upperStrength.Add(exercise);
    }
}