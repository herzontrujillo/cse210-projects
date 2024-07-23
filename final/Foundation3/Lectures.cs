using System;

public class Lecture : Event
{
    private string _speaker;
    private int _capacity;

    public Lecture(string title, string description, string date, string time, Location  address, string speaker, int capacity) : base (title, description, date, time, address)
    {
        this._speaker = speaker;
        this._capacity = capacity;
    }

    public string SetSpeaker() { return _speaker; }

    public string EventType() { return "Lecture";}

    public override string RenderFullDetail()
    {
        string fullDetail = base.RenderFullDetail();
        return $"{fullDetail}\n>> Type: {EventType()}\n>> Presenter: {_speaker}\n>> Capacity: {_capacity} - People\n";
    }

    public override string StandarDetail()
    {
        return base.StandarDetail();
    }

}