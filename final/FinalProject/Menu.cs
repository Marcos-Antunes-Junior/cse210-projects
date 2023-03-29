using System;

public class Menu
{
    public Menu(){}

    public void DisplayListMenu()
    {
        Console.Clear();
        string userInput;
        do
        {
            Console.WriteLine("Which exercises list would you like to see? ");
            Console.WriteLine("1. Abs");
            Console.WriteLine("2. Aerobic");
            Console.WriteLine("3. Lower Body Definition");
            Console.WriteLine("4. Lower Body Strength");
            Console.WriteLine("5. Upper Body Definition");
            Console.WriteLine("6. Upper Body Strength");
            Console.WriteLine("7. Back to the main menu");
            Console.Write("Please, select an option: ");
            userInput = Console.ReadLine();
            if (userInput == "1")
            {
                Console.WriteLine("");
                Abs abs = new Abs("", "");
                abs.ReadFile();
                abs.DisplayExercisesList();
            }
            else if (userInput == "2")
            {
                Console.WriteLine("");
                Aerobic aerobic = new Aerobic("", "");
                aerobic.ReadFile();
                aerobic.DisplayExercisesList();
            }
            else if (userInput == "3")
            {
                Console.WriteLine("");
                LowerBodyDef lowerDef = new LowerBodyDef("", "");
                lowerDef.ReadFile();
                lowerDef.DisplayExercisesList();
            }
            else if (userInput == "4")
            {
                Console.WriteLine("");
                LowerBodyStrength lowerStrength = new LowerBodyStrength("", "");
                lowerStrength.ReadFile();
                lowerStrength.DisplayExercisesList();
            }
            else if (userInput == "5")
            {
                Console.WriteLine("");
                UpperBodyDef upperDef = new UpperBodyDef("", "");
                upperDef.ReadFile();
                upperDef.DisplayExercisesList();
            }
            else if (userInput == "6")
            {
                Console.WriteLine("");
                UpperBodyStrength upperStrength = new UpperBodyStrength("", "");
                upperStrength.ReadFile();
                upperStrength.DisplayExercisesList();
            }
            else if (userInput == "7")
            {
                break;
            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("Wrong option! Please, try again.");
                Thread.Sleep(2500);
                Console.Clear();
            }
        } while (userInput != "7");
    }
    public void AddNewExerciseMenu()
    {
        Console.Clear();
        string userInput;
        do
        {
            Console.WriteLine("Which workout would you like to choose? ");
            Console.WriteLine("1. Abs");
            Console.WriteLine("2. Aerobic");
            Console.WriteLine("3. Lower Body Definition");
            Console.WriteLine("4. Lower Body Strength");
            Console.WriteLine("5. Upper Body Definition");
            Console.WriteLine("6. Upper Body Strength");
            Console.WriteLine("7. Back to the main menu.");
            Console.Write("Please, select an option: ");
            userInput = Console.ReadLine();
            if(userInput == "1")
            {      
                Console.Clear();
                Console.WriteLine("What is the name of the exercise? ");
                string name = Console.ReadLine();
                Console.WriteLine("What is the description?(how to do it) ");
                string description = Console.ReadLine();
                Abs abs = new Abs(name, description);
                abs.ReadFile();
                abs.AddNewExercise();
                abs.SaveInfoFile(); 
                Console.WriteLine("New exercise added!");
                Thread.Sleep(2500);
                Console.Clear();
            }
            else if(userInput == "2")
            {
                Console.Clear();
                Console.WriteLine("What is the name of the exercise? ");
                string name = Console.ReadLine();
                Console.WriteLine("What is the description?(how to do it) ");
                string description = Console.ReadLine();
                Aerobic aerobic = new Aerobic(name, description);
                aerobic.ReadFile();
                aerobic.AddNewExercise();
                aerobic.SaveInfoFile();
                Console.WriteLine("New exercise added!");
                Thread.Sleep(2500);
                Console.Clear();
            }
            else if (userInput == "3")
            {
                Console.Clear();
                Console.WriteLine("What is the name of the exercise? ");
                string name = Console.ReadLine();
                Console.WriteLine("What is the description?(how to do it) ");
                string description = Console.ReadLine();
                LowerBodyDef lowerDef = new LowerBodyDef(name, description);
                lowerDef.ReadFile();
                lowerDef.AddNewExercise();
                lowerDef.SaveInfoFile();
                Console.WriteLine("New exercise added!");
                Thread.Sleep(2500);
                Console.Clear();
            }
            else if (userInput == "4")
            {
                Console.Clear();
                Console.WriteLine("What is the name of the exercise? ");
                string name = Console.ReadLine();
                Console.WriteLine("What is the description?(how to do it) ");
                string description = Console.ReadLine();
                LowerBodyStrength lowerStrength = new LowerBodyStrength(name, description);
                lowerStrength.ReadFile();
                lowerStrength.AddNewExercise();
                lowerStrength.SaveInfoFile();
                Console.WriteLine("New exercise added!");
                Thread.Sleep(2500);
                Console.Clear();                
            }
            else if (userInput == "5")
            {
                Console.Clear();
                Console.WriteLine("What is the name of the exercise? ");
                string name = Console.ReadLine();
                Console.WriteLine("What is the description?(how to do it) ");
                string description = Console.ReadLine(); 
                UpperBodyDef upperDef = new UpperBodyDef(name, description);
                upperDef.ReadFile();
                upperDef.AddNewExercise();
                upperDef.SaveInfoFile();
                Console.WriteLine("New exercise added!");
                Thread.Sleep(2500);
                Console.Clear();
            }
            else if (userInput == "6")
            {
                Console.Clear();
                Console.WriteLine("What is the name of the exercise? ");
                string name = Console.ReadLine();
                Console.WriteLine("What is the description?(how to do it) ");
                string description = Console.ReadLine(); 
                UpperBodyStrength upperStrength = new UpperBodyStrength(name, description);
                upperStrength.ReadFile();
                upperStrength.AddNewExercise();
                upperStrength.SaveInfoFile();
                Console.WriteLine("New exercise added!");
                Thread.Sleep(2500);
                Console.Clear();
            }
            else if (userInput == "7")
            {
                break;
            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("Wrong option! Please, try again.");
                Thread.Sleep(2500);
                Console.Clear();
            }
        }while(userInput != "7");
    }

    public void WorkoutChoice()
    {
        DayOfWeek weekday = DateTime.Today.DayOfWeek;
        string today = weekday.ToString();
        if(today == "Sunday")
        {
            Console.WriteLine("Enjoy the day and take a rest!");
        }
        else if(today == "Monday")
        {
            UpperBodyStrength upper = new UpperBodyStrength("", "");
            upper.LevelChoice();
        }
        else if(today == "Tuesday")
        {
            LowerBodyStrength lowerDef = new LowerBodyStrength("", "");
            lowerDef.LevelChoice();
        }
        else if(today == "Wednesday")
        {
            Abs abs = new Abs("", "");
            abs.LevelChoice();
        }
        else if(today == "Thursday")
        {
            UpperBodyDef upperDef = new UpperBodyDef("", "");
            upperDef.LevelChoice();
        }
        else if(today == "Friday")
        {
            LowerBodyDef lowerDef = new LowerBodyDef("", "");
            lowerDef.LevelChoice();
        }
        else if(today == "Saturday")
        {
            Aerobic aerobic = new Aerobic("", "");
            aerobic.LevelChoice();
        }   
    }

    public void ProgressMenu()
    {
        Console.Clear();
        string userInput;
        do
        {   
            Console.WriteLine("Here you can calculate your body mass index(BMI) and register your current weight.");
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1. Register progress");
            Console.WriteLine("2. Load Progress");
            Console.WriteLine("3. Back to the main menu");
            Console.Write("Please, select an option: ");
            userInput = Console.ReadLine();
            if(userInput == "1")
            {
                Console.WriteLine("What is your name? ");
                string name = Console.ReadLine();
                Console.WriteLine("What is your weight in kg?");
                float weightInKg = float.Parse(Console.ReadLine());
                Console.WriteLine("What is your height in m?");
                float heightInM = float.Parse(Console.ReadLine());
                Progress progress = new Progress(name, "", weightInKg, heightInM);
                float bmiCalculator = progress.BMICalculator(weightInKg, heightInM);
                progress.BMICategories(bmiCalculator);
                progress.SaveInfoFile();
                Console.WriteLine("Informations registered!");
                Console.WriteLine("");
            }
            else if(userInput == "2")
            {
              Progress progress = new Progress("", "", 0, 0);
              if(new FileInfo("progress.txt").Length == 0)
              {
                Console.WriteLine("");
                Console.WriteLine("Empty file! Please register your progress before loading.");
                Thread.Sleep(3500);
                Console.Clear();
              }
              else
              {
                progress.ReadFile();
              }             
            }
            else if(userInput == "3")
            {
                break;
            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("Wrong option! Please, try again.");
                Thread.Sleep(2500);
                Console.Clear();
            }
        }while(userInput != "3");
    }
}