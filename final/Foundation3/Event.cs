using System;

public class Event
{
    private string _title;
    private Location _address;
    private string _date;
    private string _time;
    private string _description;

    public Event(string title, string description, string date, string time, Location address)
    {
        this._title = title;
        this._address = address;
        this._date = date;
        this._time = time;
        this._description = description;   
    }

    public virtual string SumaryDetail()
    {
        return $">> Event; {_title}\n>> Description: {_description}\n>> Date: {_date}.\n"; 
    }

    public virtual string StandarDetail() 
    {   
        return $">> Event; {_title}\n>> Date: {_date} - Time: {_time}\n>> Place: {_address}.\n"; 
    }
    public virtual string RenderFullDetail()
    {
        return $">> Event; {_title}\n>> Description: {_description}\n>> Date: {_date} - Time: {_time}\nPlace: {_address}.\n"; 

    }
}