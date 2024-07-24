using System;

public class Running : Activity
{
    public double _jogDistance;
public Running(string date, double length, double distance) : base("Running", date, length)
{
   double _jogDistance = distance;
}

    // Speed (mph or kph) = (distance / minutes) * 60
    public override double GetSpeed()
    {
        double _speed = _distance /_length;
        return _speed * 60;
    }

    // Pace (min per mile or min per km)= minutes / distance ***(Pace = 60 / speed)***
    public override double GetPace()
    {
        return 60 / GetSpeed();
    }

    public override double GetDistance()
    {
        return _distance;
    }



}