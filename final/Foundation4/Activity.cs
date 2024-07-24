using System;

public abstract class Activity
{
    protected string _date;
    protected string _activity;
    protected double _length;
    protected double _distance;
    public double _pace;
    public double _speed; 

    public Activity(string activity,string date, double length)
    {
        _activity = activity;
        _date = date;
        _length = length;        
    }

    public virtual double GetSpeed() { return _speed; }
    
    public virtual double GetPace() { return _pace; }

    public virtual double GetDistance() 
    {
        return _distance;
    }

    public virtual string Summary()
    {
        
        return $"🔘 {_date} - {_activity} , ({_length} min) 🔘 Distance: {_distance} miles, 🔘 Speed: {_speed} mph.,  🔘 Pace: {_pace} min/mile.\n";
    }

}