using System.Data.Common;
using System.IO.Enumeration;
using System.Net.NetworkInformation;
using System.Security.Cryptography.X509Certificates;

public class GoalManager 
{
    string fileName = "";
    string finishedGoal ="";
    protected List<Goal> _goals = new List<Goal>();
    protected string _name;
    protected string _description;
    protected int _points;
    protected bool _complete;

    public void SaveGoals()
    {
        Console.WriteLine("what is the name of the file? ");
        fileName = Console.ReadLine() + ".txt";
        using (StreamWriter file =  new StreamWriter(fileName))
        foreach (Goal  goal in _goals)
        {
            file.WriteLine(goal.SaveGoal());   
        }
    
    }

    public void AddingGoal(Goal goal)
    {
        _goals.Add(goal);
    }
    public virtual bool IsAchieved(){ return _complete;}

    public virtual int TotalPoints(){return _points;}

    public void LoadGoal()
    {
        Console.WriteLine("Enter the file name (No extention is needed)");
        string loadFile = Console.ReadLine() + ".txt";

        string[] lines = System.IO.File.ReadAllLines(loadFile);
        foreach (var line in lines)
        {
            string[] parts = line.Split(",");
            string name = parts[0];
            string description = parts[1];
            int points = int.Parse(parts[2]);
            bool completed = bool.Parse(parts[3]);

            if (name == _name)
            {
                _complete = completed;
                _points = points;
                Console.Write($"{_name} Goal > {IsAchieved}");
                break;
            }
        }
    }

    public void ListGoals()
    {
        Console.WriteLine("Your Goals are; ");
        for (int i = 0; i<_goals.Count(); i++)
        {
            Console.Write(i + 1);
            _goals[i].ListGoals();
        }
        Console.WriteLine("-------");
    }



    public void RecordEvents()
    {
        Console.Write("What Goal did you acomplished? ");
        int finishedGoal = Convert.ToInt32(Console.ReadLine())-1;
        if (_goals[finishedGoal].Completed() != false)
        {
            Console.WriteLine("You've donne with this Goal.");
        }
        else
        {
            _goals[finishedGoal].RecordEvent();
            Console.Write($"Well Done, you've earned {_points} points.!");
        }
    }
 

}




