using System;
using System.Collections.Generic;

public class Customer {
    private string _customerName;
    private Address _address;

    public Customer(string name, Address address)
    {
        _customerName = name;
        _address = address;
    }

    public string GetShippingLabel()
    {
        return $"{_customerName}\n{_address.GetAddress()}";
    }

    public bool IsBasedInUSA()
    {
        return _address.BasedInUSA();
    }
} 