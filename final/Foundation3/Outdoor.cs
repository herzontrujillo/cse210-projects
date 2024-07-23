using System;

public class Outdoor : Event
{
    private string _weather;

    public Outdoor(string title, string description, string date, string time, Location address, string weather) : base (title, description, date, time, address)
    {
        this._weather = weather;
    }

    public string EventType() { return "Outdoor Event.";}

    public override string RenderFullDetail()
    {
        string fullDetail = base.RenderFullDetail();
        return $"{fullDetail}\n>> Type: {EventType()}\n>> Forecast: {_weather}.\n";
    }
}