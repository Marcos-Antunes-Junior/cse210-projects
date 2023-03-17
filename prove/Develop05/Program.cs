using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Welcome to the Eternal Quest Program");
        string userInput;
        string fileName;
        List<Goal> goals = new List<Goal>();
        DisplayGoals display = new DisplayGoals();
        do
        {
            Console.WriteLine($"You have: {display.DisplayTotalPoints()} points.");
            Console.WriteLine("");
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Save Goals");
            Console.WriteLine("  4. Load Goals");
            Console.WriteLine("  5. Record Event");
            Console.WriteLine("  6. Quit");
            Console.Write("Select a choice from the menu: ");
            userInput = Console.ReadLine();
            if (userInput == "1")
            {
                Console.WriteLine("The types of Goals are: ");
                Console.WriteLine("  1. Simple Goal");
                Console.WriteLine("  2. Eternal Goal");
                Console.WriteLine("  3. Checklist Goal");
                Console.Write("Which type of goal would you like to create? ");
                string typeGoal = Console.ReadLine();
                if (typeGoal == "1")
                {
                    Console.WriteLine("");
                    SimpleGoal simple = new SimpleGoal("", "", 0, false);
                    simple.NewGoal();
                    goals.Add(simple);
                    Console.Clear();
                }
                else if (typeGoal == "2")
                {   
                    Console.WriteLine("");
                    EternalGoal eternal = new EternalGoal("", "", 0);
                    eternal.NewGoal();
                    goals.Add(eternal);
                    Console.Clear();
                }
                else if (typeGoal == "3")
                {
                    Console.WriteLine("");
                    ChecklistGoal checklist = new ChecklistGoal("", "", 0, 0, 0, 0);
                    checklist.NewGoal();
                    goals.Add(checklist);
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("Error! Please, insert the correct number.");
                    Console.Clear();
                }
            }
            else if (userInput == "2")
            {
               display.ListGoals(goals); 
            }
            else if (userInput == "3")
            {
                Console.Write("What is the name of the file? ");
                fileName = Console.ReadLine();
                if (fileName == "goals.txt")
                {
                    display.SaveGoals(goals, fileName);
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("Wrong file name!");
                    Console.Clear();
                }
            }
            else if (userInput == "4")
            {
                Console.Write("What is the name of the file? ");
                fileName = Console.ReadLine();
                if (fileName == "goals.txt")
                {   
                    display.LoadGoals(goals, fileName);
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("Wrong file name!");
                    Console.Clear();
                }
            }
            else if (userInput == "5")
            {
                display.RecordEvent(goals);
                Console.WriteLine($"You now have {display.DisplayTotalPoints()} points.");
            }
        } while (userInput != "6");
    }
}