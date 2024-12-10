using System;
using System.Security.Cryptography;

public class Address
{
    private string _street;
    private string _city;
    private string _state;
    private string _country;

    public Address(string street, string city, string state, string country)
    {
        _street = street;
        _city = city;
        _state = state;
        _country = country;
    }

    public bool CheckCountry()
    {
        if (_country == "United States")
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public string CompileAddress()
    {
        return $"{_street}\n{_city}, {_state}\n{_country}";
    }
}