using System;
using System.Collections.Generic;
// using System.Security.Cryptography;


public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;

    public void Display()
    {
        
        Console.WriteLine($"{_date} >{_promptText}\n {_entryText}");

    }

}