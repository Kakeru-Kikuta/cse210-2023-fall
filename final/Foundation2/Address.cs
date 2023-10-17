using System;
using System.ComponentModel;

class Address
{
    private string _streetAddress;
    private string _city;
    private string _stateOrProvince;
    private string _country;
    private bool _isUS;

    public Address(string streetAddress, string ctiy, string stateOrProvince, string country, bool isUS)
    {
        _streetAddress = streetAddress;
        _city = ctiy;
        _stateOrProvince = stateOrProvince;
        _country = country;
        _isUS = isUS;
    }

    // GetAddressString Method
    public string GetAddressString()
    {
    //      Build the address string

    //      RETURN S"..." *similar to display for video and comment class
        return $"{_streetAddress} {_city} {_stateOrProvince} {_country}";
    }

    public bool GetIsUS()
    {
        return _isUS;
    }

}
