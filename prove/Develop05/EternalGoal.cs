using System;

 public class EternalGoal : Goal
{
    int _attempts = 0;
    string saveGoal = "";
    public EternalGoal()
   {
        _name = "";
        _description = "";
        _points = 0;
        _completed = false;
    }

    public EternalGoal(string name, string description, int points) 
    {
        _name = name;
        _description = description;
        _points = points;

    }

    public override void CreateNewGoal()
    {
        GetGoalData();
    }

    public override void ListGoals()
    {
        Console.Write($"[ ]{_name}-{_description}");
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

    public override void RecordEvent()
    {
        _attempts ++;
    }
    public override string SaveGoal()
    {
        saveGoal = $"{_name}-{_description}-{_points}";
        return saveGoal;
    }
}
