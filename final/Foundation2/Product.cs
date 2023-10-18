using System;
using System.Xml.Schema;

public class Product
{
    private string _name;
    private string _productID;
    private float _price;
    private int _quantity;
    public string ProductID{ get{return _productID;} set{_productID = value;}}
    public string Name{ get{return _name;} set{_name = value;}}
    // product.Name
    // product.Name = "..."

    public Product( string name, string poductID, float price, int quantity )
    {
        _name = name;
        _productID = poductID;
        _price = price;
        _quantity = quantity;
    }
    

    public float ComputePrice()
    {
        return _price * _quantity;
    }
}