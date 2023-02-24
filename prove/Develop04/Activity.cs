using System;
using System.Diagnostics;

public class Activity
{
    private string _activityName;
    private string _activityDescription;
    private string _finishingMessage;
    private int _millisecondsTime;
    private int _numberConverted;
    private int _activityTime;

    public Activity(string activityName, string activityDescription, string finishingMessage)
    {
        _activityName = activityName;
        _activityDescription = activityDescription;
        _finishingMessage = finishingMessage;
    }

    public string GetActivityName()
    {
        return $"Welcome to the {_activityName} activity!";
    }

    public string GetActivityDescription()
    {
        return _activityDescription;
    }

    public string GetFinishingMessage()
    {
        return _finishingMessage;
    }

    public void Loading()
    {
        var sw = new Stopwatch();
        sw.Start();
        while (sw.ElapsedMilliseconds < 4000)
        {
            Console.Write("|");
            Thread.Sleep(300);
            Console.Write("\b \b");
            Console.Write("/");
            Thread.Sleep(300);
            Console.Write("\b \b");
            Console.Write("-");
            Thread.Sleep(300);
            Console.Write("\b \b");
            Console.Write("\\");
            Thread.Sleep(300);
            Console.Write("\b \b");
            Console.Write("|");
            Console.Write("\b \b");
        }
        sw.Stop();

    }

    public void LongLoading()
    {
        var sw = new Stopwatch();
        sw.Start();
        while (sw.ElapsedMilliseconds < 15000)
        {
            Console.Write("|");
            Thread.Sleep(300);
            Console.Write("\b \b");
            Console.Write("/");
            Thread.Sleep(300);
            Console.Write("\b \b");
            Console.Write("-");
            Thread.Sleep(300);
            Console.Write("\b \b");
            Console.Write("\\");
            Thread.Sleep(300);
            Console.Write("\b \b");
            Console.Write("|");
            Console.Write("\b \b");
        }
        sw.Stop();
    }

    public void CountingLoading()
    {
        Console.Write("5");
        Thread.Sleep(1000);
        Console.Write("\b \b");
        Console.Write("4");
        Thread.Sleep(1000);
        Console.Write("\b \b");
        Console.Write("3");
        Thread.Sleep(1000);
        Console.Write("\b \b");
        Console.Write("2");
        Thread.Sleep(1000);
        Console.Write("\b \b");
        Console.Write("1");
        Thread.Sleep(1000);
        Console.Write("\b \b");
        Console.WriteLine("");
    }

    public int ConvertSecInMil(string activityRunTime)
    {
        _numberConverted = Convert.ToInt32(activityRunTime);
        _millisecondsTime = 1000;
        _activityTime = _numberConverted * _millisecondsTime;
        return _activityTime;
    }

    public string FinalMessage(string activityRunTime)
    {
        return $"You have completed another {activityRunTime} seconds of the {_activityName} activity.";
    }
}