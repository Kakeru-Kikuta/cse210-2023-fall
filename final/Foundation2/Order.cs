using System;
using System.Data;
using System.Runtime;

class Order
{
    Customer _customer;
    private List<Product> products = new List<Product>();
    public Order(Customer customer)
    {
        _customer = customer;
    }
    

    public void AddProduct()
    {
        Console.Write("Enter the Name: ");
        string name = Console.ReadLine();
        Console.Write("Enter the ID: ");
        string id = Console.ReadLine();
        Console.Write("Enter the Price: ");
        float price = float.Parse(Console.ReadLine());
        Console.Write("Enter the Quantity: ");
        int quantity = int.Parse(Console.ReadLine());
        Product product = new Product(name, id, price, quantity);
        products.Add(product);
    }

    private float CalculateTotalCost()
    {
        float total = 0;
        float shipping = 0;
        foreach(Product product in products)
        {
            total += product.ComputePrice();
        }

        if(_customer.GetAddress().GetIsUS())
        {
            shipping = 5;
        }
        else
        {
            shipping = 35;
        }
        return total + shipping;
    }

    public void GetPackingLabel()
    {   
        Console.WriteLine($"Cost: {CalculateTotalCost()}");
        foreach(Product product in products)
        {
            Console.WriteLine($"Name: {product.Name} ID: {product.ProductID}");
        }
    }

    public void GetShippingLabel()
    {
        Console.WriteLine($"Name: {_customer.GetName()}");
        Console.WriteLine($"Address: {_customer.GetAddress().GetAddressString()}");
    }
}