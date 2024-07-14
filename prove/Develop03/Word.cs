using System;

public class Word
{
    private string _text{get;}
    // Make the string public and the set private. Otherwise will generate (Word._isHidden' is inaccessible due to its protection level) 
    // Wont let us acces to Word._isHidden
    public bool _isHidden{get; private set;}
    public Word(string text)
    {
        this._text = text;
        _isHidden = false;
    }
    public void IsHide()
    {
        _isHidden = true;
    }
    public string ShowText()
    {
        return _text;
    }
    public bool Hidden()
    {
        return _isHidden;
    }
    public override string ToString()
    {
        return _isHidden ? new string('_', _text.Length) : _text;
    }
}