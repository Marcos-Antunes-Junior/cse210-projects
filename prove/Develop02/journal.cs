using System;
using System.IO;
using System.Collections.Generic;

//This class will store user entry and will save/load it in a text file.


public class Journal
{






    public List<Entry> _entryList = new List<Entry>();


    public string _fileName;






    public void AddEntry()
    {


        Entry userEntry = new Entry();

        //Get current date
        DateTime theCurrentTime = DateTime.Now;
        userEntry._dateText = theCurrentTime.ToShortDateString();

        //Random prompt
        PromptGenerator prompt = new PromptGenerator();
        //Store prompt data in a variable.
        userEntry._displayedPrompt = prompt.Display();
        //Print prompt
        Console.WriteLine(userEntry._displayedPrompt);

        //User input
        userEntry._userInput = Console.ReadLine();



        _entryList.Add(userEntry);










    }



    public void Display()
    {


        foreach (Entry entry in _entryList)
        {
            entry.Display();

        }






    }

    public void Load()
    {

        _fileName = "journal.txt";
        string[] lines = System.IO.File.ReadAllLines(_fileName);

        foreach (string line in lines)
        {
            string[] parts = line.Split(",");

            string firstName = parts[0];

        }


    }




    public void Save()
    {
        _fileName = "journal.txt";


        using (StreamWriter outputFile = new StreamWriter(_fileName, true))
        {

            foreach (Entry entry in _entryList)
            {
                outputFile.WriteLine($"Date: {entry._dateText} - Prompt: {entry._displayedPrompt}\n" +
                $"Answer: {entry._userInput}");
                outputFile.WriteLine();

            }





        }
    }







}