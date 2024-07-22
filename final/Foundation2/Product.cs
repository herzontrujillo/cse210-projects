public class Product
{
    private string _name;
    private string _id;
    private double _quantity;
    private double _price;

    public Product(string name, string id, double quantity, double price)
    {
        this._name = name;
        this._id = id;
        this._quantity = price;
        this._price = quantity;
    }

    public string GetName() {return _name;}

    public string GetId() {return _id;}

    public double GetQuantity() {return _quantity;}

    public double GetIndividualPrice() {return _price;}

    public double GetTotalPrice()
    {
        double total = _quantity * _price;
        return total;
    }
}