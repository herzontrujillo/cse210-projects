using System;
public class Customer
{
    private Address _address;
    private string _name;
    public Customer(string name, Address address)
    {
        this._name = name;
        this._address = address;
    }

    public string GetName(){ return _name;}
    
    public bool LivesInUsa() { return _address.IsInUsa();}

    public string GetAddress() { return _address.GetFullAddress();}

}