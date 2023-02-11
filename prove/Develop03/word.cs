using System;
//This class will keep track of a single word, whether it is hidden or shown. 

public class Word
{
    private string _word;
    private bool _isHidden;

    public Word(string word)
    {
        _word = word;
        _isHidden = false;
    }

    //It will be used for hiding words using '_'.
    public void Hidden()
    {
        _word = new string('_', _word.Length);
        _isHidden = true;
    }

    //Getters and Setters   
    public bool GetHidden()
    {
        return _isHidden;
    }

    public string GetWord()
    {
        return _word;
    }
}
