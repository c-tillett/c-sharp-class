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
    public string CustomerName
    {
        get {return _name;}
        set {_name = value;}
    }
    public Address CustomerAddress
    {
        get {return _address;}
        set {_address = value;}
    }
    public bool checkCustomerCountry()
    {
        return CustomerAddress.CheckCountry();
    }
}