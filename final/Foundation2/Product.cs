using System;
using System.Xml.Schema;

public class Product
{
    private string _name;
    private string _productID;
    private int _price;
    private int _quantity;

    public Product( string name, string poductID, int price, int quantity )
    {
        //      Set the attributes
        _name = name;
        _productID = poductID;
        _price = price;
        _quantity = quantity;
    }
    

    public int ComputePrice()
    {
        total = price*quantity;
    }

    
}