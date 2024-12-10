using System;

public class Product
{
    private string _productName;
    private int _productQuantity;
    private double _productCost;
    private int _productID;
    public int pdoductID
    {
        get {return _productID;}
        set {_productID = value;}
    }

    public Product(string productName, int productQuantity, double productCost, int productID)
    {
        _productName = productName;
        _productQuantity = productQuantity;
        _productCost = productCost;
        _productID = productID;
    }

    public double totalPrice()
    {
        double totalCost = _productQuantity * _productCost;
        return totalCost;
    }

    public string FormatProductInfo()
    {
        double cost = _productCost * _productQuantity;
        cost = Math.Round((double)cost, 2);
        return $"{_productName} - - - - {_productQuantity} - - - - - ${cost}";
    }

}