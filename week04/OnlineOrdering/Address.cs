using System;
using System.Collections.Generic;

public class Address 
{
    private int _streetnumber;
    private string _streetName;
    private string _city;
    private string _state;
    private string _country;

    public Address(int number, string name, string city, string state, string country)
    {
        _streetnumber = number;
        _streetName = name;
        _city = city;
        _state = state;
        _country = country;
    }

    public string GetAddress()
    {
        return $"{_streetnumber} {_streetName}, {_city}, {_state} {_country}";
    }

    public bool BasedInUSA()
    {
        return _country.ToLower() == "usa";
    }
}