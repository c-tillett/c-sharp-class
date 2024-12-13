using System;

public class Order
{
    private List<Product> _productList = new List<Product>();
    private Customer _customer;

    public Order(Customer customer, List<Product> productList)
    {
        _customer = customer;
        _productList = productList;
    }
    public double CalculateFinalPrice()
    {
        double runningTotal = 0;
        foreach (Product product in _productList)
        {
            runningTotal = runningTotal + product.totalPrice();
        }
        if (_customer.checkCustomerCountry())
        {
            runningTotal = runningTotal +5;
            runningTotal = Math.Round((double)runningTotal, 2);
            return runningTotal;
        }
        else
        {
            runningTotal = runningTotal +35;
            runningTotal = Math.Round((double)runningTotal, 2);
            return runningTotal;
        }
    }

    public void PrintPackingLabel()
    {
        Console.WriteLine($"{_customer.CustomerName}");
        foreach (Product product in _productList)
        {
            Console.WriteLine(product.FormatProductInfo());
        }
    }

    public void PrintShippingLabel()
    {
        string name = _customer.CustomerName;
        string compiledAddress = _customer.CustomerAddress.CompileAddress();
        Console.WriteLine($"{name}\n{compiledAddress}");
    }
}