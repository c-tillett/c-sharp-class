using System;

public class Customer
{
    private string _name;
    private Address _address;
    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }
    public string customerName
    {
        get {return _name;}
        set {_name = value;}
    }
    public Address address
    {
        get {return _address;}
        set {_address = value;}
    }
    public void DisplayCustomerInfo()
    {
        Console.WriteLine($"{_name}");
        Console.WriteLine($"{_address}");
    }

    public bool checkCustomerCountry()
    {
        return address.CheckCountry();
    }
}