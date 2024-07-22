using System;

public class CheckupList : Goal
{
    string xMark = "x";
    string saveGoal = "";
    private int _attempts;
    private int _attemptsCounter;
    private int _bonus;
    private int _ongoingAttempts;

    public CheckupList()
     {
        _name = "";
        _description = "";
        _points = 0;
        _completed = false;
    }



    public CheckupList(string name, string description, int points, int attempts, int bonus) 
    {
        this._name = name;
        this._description = description;
        this._bonus = bonus;
        this._attempts = attempts;
        this._points = points;
    }

    public override void CreateNewGoal()
    {
        GetGoalData();
    }

    public override bool Completed()
    {
        if (_attempts <= _attemptsCounter)
        {
            return true;     
        }
        else
        {
            return false;
        }
    }

    

    public override void ListGoals()
    {
        bool done = Completed();

        if (done != true)
        {
            xMark = " ";
        }
        else
        {
            Console.WriteLine($"[{xMark}]- {_name}-{_description}");
        }

    }
    public override void RecordEvent()
    {
        _ongoingAttempts++;
    }

    public override string SaveGoal()
    {
        saveGoal = $"{_name}-{_description}-{_points}";
        return saveGoal;
    }


}