using System;
using System.IO;


    public class SimpleGoal : Goal
{
    string _done = "x";
    string saveGoal = "";
    public SimpleGoal()
    {
        _name = "";
        _description = "";
        _points = 0;
        _completed = false;
    }

    public SimpleGoal(string name, string description, int points, bool done) 
    {
        this._name = name;
        this._description = description;
        this._points = points;
        this._completed = done;
        
    }
    public override void CreateNewGoal()
    {   
        GetGoalData();
    }
    public override bool Completed()
    {
        if (_completed != true)
        {
            return false;
        }
        else
        {
            return true;
        }
    }
    public override string SaveGoal()
    {
        saveGoal = $"{_name}-{_description}-{_points}";
        return saveGoal;
    }

    public override void RecordEvent()
    {
        if (_completed != false)
        {
            Console.WriteLine("You completed this Goal.");
        }
    }

    public override void ListGoals()
    {
        bool done = Completed();
        if (done == true)
        {
            Console.WriteLine($"[{_done}]-{_name}-{_description}-{_points}.");
        }
        else
        {
            Console.WriteLine($"[ ]-{_name}-{_description}-{_points}.");
        }
    }

}
