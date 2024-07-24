using System;

public class Swimming : Activity
{
    private double _swimmingLaps;

    public Swimming(string date, double length, double laps) : base("swimming", date, length)
    {
        this._swimmingLaps = laps;
    }

    //Speed (mph or kph) = (distance / minutes) * 60
    public override double GetSpeed()
    {
        double  speed = GetDistance()/_length * 60;
        double _speed = Math.Round(speed, 2);
        return _speed;
    }

    //Pace (min per mile or min per km)= minutes / distance
    public override double GetPace()
    {
        double pace = _length/_distance;
        double _pace = Math.Round(pace,2);
        return _pace;
    }

    // Distance (miles) = swimming laps * 50 / 1000 * 0.62
    public override double GetDistance()
    {
        double distance = _swimmingLaps * 50 /1000 * 0.62;
        double _distance = Math.Round(distance,2);
        return _distance;
    }

}