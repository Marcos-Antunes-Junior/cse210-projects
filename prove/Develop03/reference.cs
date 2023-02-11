using System;
using System.IO;
//This class will keep track the book, chapter and verses.

public class Reference
{
    private string _book;
    private string _chapter;
    private string _initVerse;
    private string _endVerse;

    //Use it if the scripture has only one verse.
    public Reference(string book, string chapter, string initVerse)
    {
        _book = book;
        _initVerse = initVerse;
        _chapter = chapter;
    }

    //Use it if the scripture has more than one verse.
    public Reference(string book, string chapter, string initVerse, string endVerse)
    {
        _book = book;
        _initVerse = initVerse;
        _chapter = chapter;
        _endVerse = endVerse;
    }

    //Getters and Setters
    public string GetBook()
    {
        return _book;
    }
    public string GetChapter()
    {
        return _chapter;
    }
    public string GetInitialVerse()
    {
        return _initVerse;
    }
    public string GetEndVerse()
    {
        return _endVerse;
    }
}

