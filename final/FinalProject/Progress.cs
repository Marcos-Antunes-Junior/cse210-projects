using System;

public class Progress : Exercises
{
    private string _name;
    private string _description;
    private float _weightInKg;
    private float _heightInM;
    private float _bodyMassIndex;

    public Progress(string name, string description, float weightInKg, float heightInM) : base(name, description)
    {
        _name = name;
        _description = description;
        _weightInKg = weightInKg;
        _heightInM = heightInM;
    }

    public float BMICalculator(float weightInKg, float heightInM)
    {    float squareHeight = heightInM * 2;
        _bodyMassIndex = float.Round(weightInKg / squareHeight, 2);
        return _bodyMassIndex;
    }

    public void BMICategories(float bodyMassIndex)
    {
        float bmiCalculator = BMICalculator(_weightInKg, _heightInM);
        if(bmiCalculator < 18.5)
        {
           Console.WriteLine("");
           Console.WriteLine($"Your Body Mass Index(BMI) is: {bmiCalculator}.");
           Console.WriteLine("You are in the underweight range.");  
           Console.WriteLine("");        
        }
        else if(bmiCalculator > 18.5 && bmiCalculator <= 24.9)
        {
           Console.WriteLine("");
           Console.WriteLine($"Your Body Mass Index(BMI) is: {bmiCalculator}.");
           Console.WriteLine("Very good! You are in the healthy weight range."); 
           Console.WriteLine("");
        }
        else if(bmiCalculator > 24.9 && bmiCalculator <= 29.9)
        {
           Console.WriteLine("");
           Console.WriteLine($"Your Body Mass Index(BMI) is: {bmiCalculator}.");
           Console.WriteLine("You are in the overweight range."); 
           Console.WriteLine("");
        }
        else if(bmiCalculator > 29.9)
        {
           Console.WriteLine("");
           Console.WriteLine($"Your Body Mass Index(BMI) is: {bmiCalculator}.");
           Console.WriteLine("You are in the obese range."); 
           Console.WriteLine("");
        }
    }

    public override void SaveInfoFile()
    {
        string filename = "progress.txt";
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine($"{_name}, {_weightInKg}, {_heightInM}, {_bodyMassIndex}");
        }
    }

    public override void ReadFile()
    {
        string filename = "progress.txt";
        string [] lines = System.IO.File.ReadAllLines(filename);
        foreach(string line in lines)
        {   
            string[] parts = line.Split(", ");
            string name = parts[0];
            string weight = parts[1];
            string height = parts[2];
            string bodyMassIndex = parts[3];
            Console.WriteLine("");
            Console.WriteLine($"Name: {name}\n" + 
            $"Weight in Kg: {weight}\n" +
            $"Height in m: {height}\n" +
            $"Body Mass Index (BMI): {bodyMassIndex}");
            Console.WriteLine("");
            Console.WriteLine("Progress loaded!");
            Console.WriteLine("");           
        }
    }
}