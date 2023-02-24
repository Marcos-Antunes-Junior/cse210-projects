using System;

public class Listing : Activity
{
    private List<string> _listingQuestions = new List<string>{
"--- Who are people that you appreciate? ---",
"--- What are personal strengths of yours? ---",
"--- Who are people that you have helped this week? ---",
"--- When have you felt the Holy Ghost this month? ---",
"--- Who are some of your personal heroes? ---"
};
    private List<int> _availableIndex1 = new List<int>();
    private string _userInput;
    private int _randomIndex1;
    private int _listIndex1;
    private string _question1;

    public Listing(string activityName, string activityDescription, string finishingMessage) : base(activityName, activityDescription, finishingMessage)
    {
        activityName = "";
        activityDescription = "";
        finishingMessage = "";
    }
    public List<int> Populate()
    {
        for (int i = 0; i < _listingQuestions.Count; i++)
        {
            _availableIndex1.Add(i);
        }
        return _availableIndex1;
    }

    public string QuestionsDisplay()
    {
        Random random = new Random();
        _randomIndex1 = random.Next(_availableIndex1.Count);
        _listIndex1 = _availableIndex1[_randomIndex1];
        _question1 = (_listingQuestions[_listIndex1]);
        _availableIndex1.Remove(_randomIndex1);
        return _question1;
    }

    public void StartListingActivity()
    {
        ClearCurrentConsoleLine();
        Console.Write("> ");
        _userInput = Console.ReadLine();
        Console.SetCursorPosition(0, Console.CursorTop - 1);
        Console.WriteLine($"> {_userInput}");
    }

    public void ClearCurrentConsoleLine()
    {
        int currentLineCursor = Console.CursorTop;
        Console.SetCursorPosition(0, Console.CursorTop);
        Console.Write(new string(' ', Console.WindowWidth));
        Console.SetCursorPosition(0, currentLineCursor);
    }
}