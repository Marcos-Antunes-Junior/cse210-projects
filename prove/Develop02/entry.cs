using System;
using System.Collections.Generic;

//This class will output the user input, the random prompt and the current date.
public class Entry
{




    public string _userInput;



    public string _dateText;

    public string _displayedPrompt;

    public void Display()
    {

        Console.WriteLine($"Date: {_dateText} - Prompt: {_displayedPrompt}\n" +
        $"Answer: {_userInput}");
        Console.WriteLine();


    }










}