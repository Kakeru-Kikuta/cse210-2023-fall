using System;
using System.Dynamic;
using System.Net.Sockets;

class Customer
{
    private string _customerName;
    private Address _address;
    public Customer(string customerName, Address address)
    {
        _customerName = customerName;
        _address = address;
    }
    
    // Getter method for the address GetAdress()
    public Address GetAddress()
    {
        return _address;
    }

    //Getter for the name GetName()
    public string GetName()
    {
        return _customerName;
    }
}