using System;

public class Address 
{
    private int _streetnumber;
    private string _streetName;
    private string _city;
    private string _state;
    private string _country;

    public Address(int number, string name, string city, string state, string country)
    {
        number = _streetnumber;
        name = _streetName;
        city = _city;
        state = _state;
        country = _country;
    }

    public string GetAddress()
    {
        return $"{_streetnumber} {_streetName}, {_city}, {_state} {_country}";
    }
}