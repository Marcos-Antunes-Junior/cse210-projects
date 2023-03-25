using System;

class Program
{
    static void Main(string[] args)
    { 
      string userInput;
      Menu menu = new Menu();
      do
      {
        Console.Clear();
        Console.WriteLine("Welcome to the Daily Workout Routine Program!");
        Console.WriteLine("");
        Console.WriteLine("***This program aims to help people improve their quality of life.\n" +
        "However, this is not a substitute for professional help.***"); 
        Console.WriteLine("");
        Console.WriteLine("Menu Options:");
        Console.WriteLine("1. Start workout");
        Console.WriteLine("2. Add new exercise");
        Console.WriteLine("3. Show availables exercises");
        Console.WriteLine("4. Progress");
        Console.WriteLine("5. Exit");
        Console.Write("Please, select an option: ");
        userInput = Console.ReadLine();
        if(userInput == "1")
        {
          menu.WorkoutChoice();
        }
        else if(userInput == "2")
        {
          menu.AddNewExerciseMenu();
        }
        else if(userInput == "3")
        {
          menu.DisplayListMenu();
        }
        else if(userInput == "4")
        {
          Console.WriteLine("");
          Console.WriteLine("In progress...Please, come back later.");
          Thread.Sleep(2000);
          Console.Clear();
        }
        else if(userInput == "5")
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
      }
      while(userInput != "5");     
    }
}