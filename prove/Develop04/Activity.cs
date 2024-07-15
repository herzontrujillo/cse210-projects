using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Dynamic;

public class Activity
{
    // Private strings
    private string _name = "";
    private string _description = "";
    private int _duration;

    public Activity(string name, string description, int duration)
    {
        this._name = name;
        this._description = description;
        this._duration = duration;
    }

    public void Display()
    {
        Console.WriteLine($"Welcome to {_name} activity; {_description}");
        Thread.Sleep(20);      
    }
    public void ImputTime()
    {
        Console.WriteLine("How long would you like to be in this session (time in seconds)?");
        string inputTime = Console.ReadLine();
        SetTime(Convert.ToInt32(inputTime));        
    }
    public  void SetTime(int duration) => _duration = duration;

    public int GetDuration()
    {
        return _duration;
    }
    public void StartActivity()
    {
        Display();
        ImputTime();
        Ready();
    }

    public void Ready()
    {
        Console.WriteLine("Get set....");
        // Spinner(5);
    }
    public void ClosingActivity()
    {
        Console.WriteLine("");
        // Spinner(5);
        Console.WriteLine($"You completed {_name} activity in {_duration} seconds.");
        Console.WriteLine("Well done!");
        Thread.Sleep(1000);
        
    }
    public void Spinner(int seconds)
    {
        int spinnerLocation = 50;
        spinnerLocation = Console.CursorLeft;

        while (DateTime.Now != DateTime.Now.AddSeconds(2))    
        {
            char[] spin = new char[]{'+', 'x','+','x'};
            foreach (char spinner in spin)
            {
                Console.CursorLeft = spinnerLocation;
                Console.Write(spinner);
                break;   
            }
        }
        return;
    }        
}