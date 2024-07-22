using System;

public class Goal
{
    string saveGoal = "";
    protected string _name;
    protected string _description;
    protected bool _completed;
    protected int _points;
    protected int  _bonusses;
    public int _scoredPoints;
    public int _times;
    
    public Goal()
    {
        _name =" ";
        _description =" ";
        _completed = false;
        _points = 0;
    }
  
    public Goal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
        _completed = false;
    }

    protected void GetGoalData()
    {
        Console.Write("What is the name of your Goal? >");
        _name = Console.ReadLine();
        Console.Write("Please give a small description of your Goal: > ");
        _description = Console.ReadLine();
        Console.Write("What is the amount of points for this Goal? > ");
        _points = Convert.ToInt32(Console.ReadLine());
        Console.Write("How many bopnus would you get after accomplishing this Goal? > ");
        _bonusses = Convert.ToInt32(Console.ReadLine());
        Console.Write("How many times do you have to achieve this Goal to obtain some bonusses? > ");
        _times = Convert.ToInt32(Console.ReadLine());


    }
    public virtual string SaveGoal()
    {
        return saveGoal;
    
    }
    public virtual void RecordEvent() {  }
    public virtual void CreateNewGoal() {  }

    public virtual bool Completed()
    {
        return  true;
    }
    public virtual void CheckListGoal(){}

    public int GetScorePoints()
    {
        return _scoredPoints;
    }
    public virtual void ListGoals()
    {
    }

}

