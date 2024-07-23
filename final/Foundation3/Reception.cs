using System;

public class Reception : Event
{
    private string _rsvp;

    public Reception(string title, string description, string date, string time, Location address, string RSVP)
        : base (title, description, date, time, address)
    {
        this._rsvp = RSVP;

    }

    public string EventType() { return "Reception Event";}

    public override string RenderFullDetail()
    {
        string fullDetail = base.RenderFullDetail();
        return $"{fullDetail}\n>> Type: {EventType()}\n>> RSVP: {_rsvp}.\n";
    }






}