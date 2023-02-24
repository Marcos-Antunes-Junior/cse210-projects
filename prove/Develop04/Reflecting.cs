using System;
using System.Collections.Generic;

public class Reflecting : Activity
{
    private int _listIndex;
    private int _randomIndex;
    private int _randomPrompt;
    private string _prompt;
    private string _question;
    private List<string> _promptList = new List<string>{
 "--- Think of a time when you stood up for someone else. ---",
 "--- Think of a time when you did something really difficult. ---",
 "--- Think of a time when you helped someone in need. ---",
 "--- Think of a time when you did something truly selfless. ---"
};
    private List<string> _questionsList = new List<string>{
"> Why was this experience meaningful to you?",
"> Have you ever done anything like this before?",
"> How did you get started?",
"> How did you feel when it was complete?",
"> What made this time different than other times when you were not as successful?",
"> What is your favorite thing about this experience?",
"> What could you learn from this experience that applies to other situations?",
"> What did you learn about yourself through this experience?",
"> How can you keep this experience in mind in the future?"
};
    private List<int> _availableIndex = new List<int>();

    public Reflecting(string activityName, string activityDescription, string finishingMessage) : base(activityName, activityDescription, finishingMessage)
    {
        activityName = "";
        activityDescription = "";
        finishingMessage = "";
    }

    public List<int> Populate()
    {
        for (int i = 0; i < _questionsList.Count; i++)
        {
            _availableIndex.Add(i);
        }
        return _availableIndex;
    }

    public string PromptDisplay()
    {
        Random random = new Random();
        _randomPrompt = random.Next(0, _promptList.Count);
        _prompt = (_promptList[_randomPrompt]);
        return _prompt;
    }

    public string StartQuestionList()
    {
        Random random1 = new Random();
        _randomIndex = random1.Next(_availableIndex.Count);
        _listIndex = (_availableIndex[_randomIndex]);
        _question = (_questionsList[_listIndex]);
        _availableIndex.RemoveAt(_randomIndex);
        return _question;
    }
}