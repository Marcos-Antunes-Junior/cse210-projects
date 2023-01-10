using System;

class Program
{
    static void Main(string[] args)
    {   
        string answer;
        do{

         int input;
         int number;
         Random randomGenerator = new Random();
         number = randomGenerator.Next(1, 11);
        do
        {
            
            
            Console.Write("What is your guess? ");
            input = int.Parse(Console.ReadLine());

            if (input < number)
            {
               Console.WriteLine("Higher.");
            }else if (input > number)
            {
                Console.WriteLine("Lower.");
            }else 
            {
                Console.WriteLine("You guessed it!");

            }


        
        
        
        
        
        
        
        }while (input < number || input > number);
        
        Console.WriteLine("Do you want to continue? ");
        answer = Console.ReadLine();
        }while (answer == "yes"); 

    }

}



        
         
        
        
        
        
        