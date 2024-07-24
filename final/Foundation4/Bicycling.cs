using System;

public class Bicycling : Activity
{
    private double _velocity;

    public Bicycling(string date, double length, double speed) : base("Bycicling", date, length)
    {
        this._velocity = speed;
    }
    
    // Speed (mph or kph) = (distance / minutes) * 60
    public override double GetSpeed()
    {
        return _length / _length *60;
    }

    // Pace (min per mile or min per km)= minutes / distance ***(Pace = 60 / speed)***
    public override double GetPace()
    {
        double _pace = 60/_speed; 
        return _pace;
    }

    public override double GetDistance()
    {
        
        return _distance;

    }








}