using System;
using System.Runtime;

class Order
{
    // Customer customer
    Customer customer = new Customer();
    // List<Product> products = new();
    private List<Product> products = new List<Product>();
    
    //Constructor Order( Customer customer )
    public Order(Customer customer)
    {
        // set customer
        
    }
    

    public void AddProduct()
    {
        // name = GET
        // ID = GET
        // ...
        //  create product object | Product product = new(name, id, price quantity)
        Product product = new Product();
        //  add product to the list
        


    }
    

    public int CalculateTotalCost()
    {
    //  Add all product prices plus one time shipping fee
    //  * shipping fee will change based on wether its in the US
    //      IF in US ( customer.GetAddress().GetIsUS())
    //          shipping cost = 5
    //      ELSE
    //          Shipping cost = 35
    //
    }

    public void GetPackingLabel()
    {
    //  Loop through the list (foreach loop)
        foreach(Product product in products)
        {
    //      PUT product name and ID
            
            
        }

    //GetShippinfLabel
    // PUT Customer name and address
    //  name: customer.GetName()
    // address: customer.GetAddress().GetAddressString()
    }
}