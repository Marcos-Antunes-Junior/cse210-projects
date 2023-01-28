using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        QuotesQuenerator prompt1 = new QuotesQuenerator();
        Journal journal = new Journal();
        //Store quote data in a variable.
        string displayedQuote = prompt1.Display();
        
        Console.WriteLine();
        Console.WriteLine("What is your name?");
        string userName = Console.ReadLine();
        Console.WriteLine();
        Console.WriteLine($"Hello {userName}, welcome to the journal program!");
        Console.WriteLine();
        Console.WriteLine("Inspirational quote: ");
        //Output quote.
        Console.WriteLine(displayedQuote);





        int i = 0;
        //Menu loop.
        do
        {
            Console.WriteLine();

            Console.WriteLine("What would you like to do?");
            Console.WriteLine();
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("Please, select the menu number corresponding to the option: ");
            i = Convert.ToInt32(Console.ReadLine());



            //Menu options.
            if (i == 1)
            {

                //Store current date, random prompt and the user input.
                journal.AddEntry();




            }
            else if (i == 2)
            {

                //Display current date, random prompt and the user input stored.
                journal.Display();


            }
            else if (i == 3)
            {   //Load text file.
                Console.WriteLine("What is the filename?");
                string filename = Console.ReadLine();



                if (filename == "journal.txt")
                {

                    journal.Load();
                    Console.WriteLine("File loaded!");
                    Console.WriteLine();



                }
                else
                {
                    {
                        Console.WriteLine();
                        Console.WriteLine("Wrong filename!");
                        Console.WriteLine();

                    }
                }


            }
            else if (i == 4)
            {   //Save current date, random prompt and the user input stored in a text file.
                Console.WriteLine("What is the filename?");
                string filename = Console.ReadLine();



                if (filename == "journal.txt")
                {
                    journal.Save();
                    Console.WriteLine("File saved!");
                    Console.WriteLine();



                }
                else
                {
                    {
                        Console.WriteLine();
                        Console.WriteLine("Wrong filename!");
                        Console.WriteLine();

                    }
                }


            }
        } while (i < 5); 

    }
}