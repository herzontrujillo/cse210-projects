using System;

public class Order
{
    private List<Product> _orders;
    private Customer _client;
    public string _pkgLabel = "";

    public Order(List<Product> order, Customer customer)
    {
        _orders = order;
        _client = customer;
    }

    
    public void Display()
    {
        string pckgLabe = PackingLabel();
        string shipLabel = ShippingLabel();
        double shipPrice = ShippingAmount();
        double total = TotalPrice();

        Console.WriteLine($"Packaging Label: \n>> {pckgLabe}");
        Console.WriteLine();
        Console.WriteLine($"Shipping Label: \n>> {shipLabel}");
        Console.WriteLine();
        Console.WriteLine($"Shipping fee: \n>>> ${shipPrice}.00");
        Console.WriteLine();
        Console.WriteLine($"Yout total amount do is: \n>>>  ${total}.00");





    }

    // Create Labels
    public string ShippingLabel()
    {
        return $"{_client.GetName()}\n{_client.GetAddress()}";
    }

    public string PackingLabel()
    {
        foreach(Product i in _orders)
        {
            _pkgLabel += $" Name: {i.GetName()} -- {i.GetId()}. >>> ";  
        }   
        return _pkgLabel;

    }

    // Calculate amounts 
    public double ShippingAmount() 
    { 
        double _totalShipping = ShippingPrice();
        return _totalShipping;
    }

    public double ShippingPrice()
    {
        if (_client.LivesInUsa())
        {
            return 5;
        }
        return 35;
    }
    public double TotalPrice()
    {
        double _totalPrice = 0;
        foreach(Product i in _orders)
        {
            double total = i.GetTotalPrice(); 
            _totalPrice =+ total;
        }
        double shipping = ShippingAmount();
        _totalPrice += shipping;
        return _totalPrice;
    }
}