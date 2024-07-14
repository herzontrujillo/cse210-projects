using System;
using System.Collections.Generic;
using System.Diagnostics;

public class Activity
{
    // Private strings
    private string _name;
    private string _description;
    private int _duration;

    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }

    public void Start()
    {
        Console.WriteLine($"Welcome to {_name} activity; {_description}");
        Thread.Sleep(5000);

        for (int i = 1; i<= _duration; i++)
        {
            Prompt(i);
        }        
    }

    protected abstract void Prompt(int index);

    protected void Animation()
    {
        Console.WriteLine("*****");
        for (int i = 0; i < 5; i++)
        {
            Thread.Sleep(3000);
            Console.Write("---");
        }
    }

    private void ClosingActivity()
    {
        Console.WriteLine($"You completed {_name} activity in {_duration} seconds.");
        Console.WriteLine("Well done!");
        Thread.Sleep(3000);
    }
}





