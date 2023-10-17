using System;
using System.Dynamic;
using System.Net.Sockets;

class Customer
{
    private string _customerName;
    private Address _address;
    ///Call Address class and its methods. <summary>
    Address address = new Address();
    // Constructor Customer( customerName, Address address )
    public Customer(string customerName, Address address)
    {
          _customerName = customerName;
          _address = address;
    }
    
    // Getter method for the address GetAdress()

    //Getter for the name GetName()

}