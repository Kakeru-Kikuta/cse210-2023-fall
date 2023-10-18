using System;
using System.Text.Json.Serialization;

class Program
{
    static void Main(string[] args)
    {
        Address address = new Address("123 A ST", "City", "Province", "US", true);
        Customer customer = new Customer("Joe", address);
        Order order = new Order(customer);
        order.AddProduct();
        order.AddProduct();
        order.AddProduct();
        order.GetPackingLabel();
        order.GetShippingLabel();
    }
}