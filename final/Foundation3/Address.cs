using System;

public class Address
{
    private string _locationName;
    private string _street;
    private string _city;
    private string _state;
    private int _zipCode;
    private string _country;
    public Address(string locationName, string street, string city, string state, int zipCode, string country)
    {
        _locationName = locationName;
        _street = street;
        _city = city;
        _state = state;
        _zipCode = zipCode;
        _country = country;
    }
    public string CompileAddress()
    {
        return $"{_locationName}\n{_street}\n{_city}, {_state}\n{_zipCode}\n{_country}";
    }

}