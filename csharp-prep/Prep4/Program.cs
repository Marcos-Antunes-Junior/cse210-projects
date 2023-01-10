using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {   int number;
        List<int> numberList = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        
        do
        {   
            
            
            Console.Write("Enter number: ");
            number = int.Parse(Console.ReadLine());
            
            if (number != 0)
            {
               numberList.Add(number);
            }
            

            
            
        }while (number != 0);
            
            
            int sum = numberList.AsQueryable().Sum();
            float average = ((float)sum) / numberList.Count;
            int max = numberList.Max();

            Console.WriteLine("The sum is: " + sum);
            Console.WriteLine("The average is: " + average);
            Console.WriteLine("The largest number is: " + max);
            
            

    }
}