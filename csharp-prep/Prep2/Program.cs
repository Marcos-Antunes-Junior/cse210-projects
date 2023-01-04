using System;

class Program
{
    static void Main(string[] args)
    {   
        Console.Write("What is your grade percentage? ");
        string userInput = Console.ReadLine();
        int number = int.Parse(userInput);
        string letter = "";
        if (number >= 90)
        {
            letter = "A";
        }
        else if(number < 90 && number >= 80)
        {
            letter = "B";
        }
        else if(number < 80 && number >= 70)
        {
            letter = "C";
        }
        else if(number < 70 && number >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"Your grade is {letter}");

        if (number < 70)
        {
            
            Console.WriteLine("");
            Console.WriteLine("You were reproved!");
        }
        else
        {
            Console.WriteLine("You were approved!");
        }

        
    }
}