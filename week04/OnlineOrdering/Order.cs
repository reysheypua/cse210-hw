class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;

    public Customer Customer => _customer;

    public Order(List<Product> products, Customer customer)
    {
        _products = products;
        _customer = customer;
    }

    public double GetTotalCost()
    {
        double productsTotal = 0;

        foreach (Product product in _products)
        {
            productsTotal += product.GetTotalCost();
        }

        double shippingCost = 0;
        if (_customer.InUSA())
        {
            shippingCost = 5;
        }
        else if (!_customer.InUSA())
        {
            shippingCost = 35;
        }

        return productsTotal + shippingCost;
    }

    public string GetPackingLabel()
    {
        string label = "";

        label += "----------PACKING LABEL----------\n";

        foreach (Product product in _products)
        {
            label += $"Name: {product.GetProductName()}\nID: {product.GetProductId()}\n\n";
        }

        return label;
    }

    public string GetShippingLabel()
    {
        string label = "";

        label += "---------SHIPPING LABEL---------\n";
        label += $"Customer: {_customer.GetName()}\n";
        label += $"Address: {_customer.GetAddress()}\n";

        return label;
    }
}