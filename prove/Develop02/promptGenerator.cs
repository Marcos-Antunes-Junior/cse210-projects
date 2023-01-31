using System;
using System.Collections.Generic;
//This class will generate random prompts.
public class PromptGenerator
{
public List<string> _promptList = new List<string>{
"Who was the most interesting person I interacted with today?",
"What was the best part of my day?",
"How did I see the hand of the Lord in my life today?",
"What was the strongest emotion I felt today?",
"If I had one thing I could do over today, what would it be?",
"What did I learn today at BYU Idaho?",
"What did I learn today in my study of the gospel of Jesus Christ?",
};

    public int _listIndex;
    public string Display()
    {
        var random = new Random();
        _listIndex = random.Next(_promptList.Count);
        string prompt = (_promptList[_listIndex]);
        return prompt;
    }
}