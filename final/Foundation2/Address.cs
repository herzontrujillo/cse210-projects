
using System;
public class Address
{
    private  string _street;
    private  string _city;
    private  string _state;
    private  string _country;
    public Address(string street, string city, string state, string country)
    {
        this._street = street;
        this._city = city;
        this._state = state;
        this._country = country;
    }

    public bool IsInUsa()
    {

        if (_country.ToLower() == "usa")
        {
            return true;
        }
            return false;   
    }

    public string GetFullAddress()
    {
        string address = $"{_street} - {_city} - {_state} - {_country}"; 
        return address;
    }
    public string GetCountry(){ return _country;}

    public string GetState(){ return _state;}

    public string GetCity(){ return _city;}

    public string GetStreet(){ return _street;}
}