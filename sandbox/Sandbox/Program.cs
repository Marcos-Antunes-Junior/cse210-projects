using System;

class Program
{
    static void Main(string[] args)
    {    
        int restTime = 0;
   for(int i = 30; i > restTime; i--)
        {   
            Console.Write("\b \b");
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
            
            
        }
    
    }
}