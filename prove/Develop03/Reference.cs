using System;

public class Reference
{
    private string _book;
    private int _chapter;
    private int _firstVerse;
    private int _endVerse;

    public Reference(string book, int chapter, int firstrtVerse)
    {
        this._book = book;
        this._chapter = chapter;
        this._firstVerse = firstrtVerse;
    }

    public Reference(string book, int chapter, int firstrtVerse, int endVerse)
    {
        this._book = book;
        this._chapter = chapter;
        this._firstVerse = firstrtVerse;
        this._endVerse = endVerse;
    }

    public string Display()
    {
        return _book + _chapter + ":" + _firstVerse;
    }


}