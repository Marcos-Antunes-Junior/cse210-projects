using System;
using System.Diagnostics;
//For exceeding core requirements, I found a way to not repeat a random prompt or question during 
//the same session. I used Populate() in Reflecting and Listing classes to avoid repeating a random 
//prompt or question.

class Program
{
    static void Main(string[] args)
    {
        string userInput;
        do
        {
            Console.Clear();
            Console.WriteLine("Welcome to the Mindfulness program!");
            Console.WriteLine("");
            Console.WriteLine("Menu Options: ");
            Console.WriteLine("1. Start breathing activity");
            Console.WriteLine("2. Start reflecting activity");
            Console.WriteLine("3. Start listing activity");
            Console.WriteLine("4. Quit");
            Console.Write("Select a choice from the menu: ");
            userInput = Console.ReadLine();
            if (userInput == "1")
            {
                Console.Clear();
                Breathing breathing = new Breathing("Breathing",
                "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.",
                "Well done!");
                string activityName = breathing.GetActivityName();
                string activityDescription = breathing.GetActivityDescription();
                Console.WriteLine(activityName);
                Console.WriteLine("");
                Console.WriteLine(activityDescription);
                Console.WriteLine("");
                Console.Write("How long, in seconds, would you like for your session? ");
                string inputTime = Console.ReadLine();
                int convertInputTime = breathing.ConvertSecInMil(inputTime);
                Console.Clear();
                Console.WriteLine("Get ready...");
                breathing.Loading();
                var sw = new Stopwatch();
                sw.Start();
                while (sw.ElapsedMilliseconds < convertInputTime)
                {
                    breathing.StartActivity();
                }
                sw.Stop();
                string finishingMessage = breathing.GetFinishingMessage();
                Console.WriteLine("");
                Console.WriteLine(finishingMessage);
                breathing.Loading();
                Console.WriteLine("");
                string finalMessage = breathing.FinalMessage(inputTime);
                Console.WriteLine(finalMessage);
                breathing.Loading();
                Console.Clear();
            }
            else if (userInput == "2")
            {
                Console.Clear();
                Reflecting reflecting = new Reflecting("Reflecting",
                "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.",
                "Well done!");
                string activityName1 = reflecting.GetActivityName();
                string activityDescription1 = reflecting.GetActivityDescription();
                string finishingMessage1 = reflecting.GetFinishingMessage();
                reflecting.Populate();
                Console.WriteLine(activityName1);
                Console.WriteLine("");
                Console.WriteLine(activityDescription1);
                Console.WriteLine("");
                Console.Write("How long, in seconds, would you like for your session? ");
                string inputTime1 = Console.ReadLine();
                int convertInputTime1 = reflecting.ConvertSecInMil(inputTime1);
                Console.Clear();
                Console.WriteLine("Get ready...");
                reflecting.Loading();
                string prompt = reflecting.PromptDisplay();
                Console.WriteLine("");
                Console.WriteLine(prompt);
                Console.WriteLine("");
                string userInput1;
                do
                {
                    Console.WriteLine("When you have something in mind, press enter to continue: ");
                    userInput1 = Console.ReadLine();
                } while (userInput1 != "");
                Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
                Console.Write("You may begin in: ");
                reflecting.CountingLoading();
                Console.Clear();
                var sw = new Stopwatch();
                sw.Start();
                while (sw.ElapsedMilliseconds < convertInputTime1)
                {
                    string question = reflecting.StartQuestionList();
                    Console.Write(question);
                    Console.Write(" ");
                    reflecting.LongLoading();
                    Console.WriteLine("");
                }
                sw.Stop();
                Console.WriteLine("");
                Console.WriteLine(finishingMessage1);
                reflecting.Loading();
                Console.WriteLine("");
                string finalMessage1 = reflecting.FinalMessage(inputTime1);
                Console.WriteLine(finalMessage1);
                reflecting.Loading();
                Console.Clear();
            }
            else if (userInput == "3")
            {
                Console.Clear();
                Listing listing = new Listing("Listing",
                "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.",
                "Well done!");
                string activityName2 = listing.GetActivityName();
                string activityDescription2 = listing.GetActivityDescription();
                listing.Populate();
                Console.WriteLine(activityName2);
                Console.WriteLine("");
                Console.WriteLine(activityDescription2);
                Console.WriteLine("");
                Console.Write("How long, in seconds, would you like for your session? ");
                string inputTime2 = Console.ReadLine();
                int convertInputTime2 = listing.ConvertSecInMil(inputTime2);
                Console.Clear();
                Console.WriteLine("Get ready...");
                listing.Loading();
                Console.WriteLine("");
                Console.WriteLine("List as many responses you can to the following prompt:");
                string listingQuestions = listing.QuestionsDisplay();
                Console.WriteLine(listingQuestions);
                Console.Write("You may begin in: ");
                listing.CountingLoading();
                var sw = new Stopwatch();
                sw.Start();
                int counting = 0;
                while (sw.ElapsedMilliseconds < convertInputTime2)
                {
                    listing.StartListingActivity();
                    counting++;
                }
                sw.Stop();
                Console.WriteLine($"You listed {counting} items!");
                Console.WriteLine("");
                string finishingMessage2 = listing.GetFinishingMessage();
                Console.WriteLine(finishingMessage2);
                listing.Loading();
                Console.WriteLine("");
                string finalMessage2 = listing.FinalMessage(inputTime2);
                Console.WriteLine(finalMessage2);
                listing.Loading();
                Console.Clear();
            }
            else if (userInput == "4")
            {
                break;
            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("Wrong option! Please, try again.");
                Thread.Sleep(2500);
            }
        } while (userInput != "4");
    }
}

