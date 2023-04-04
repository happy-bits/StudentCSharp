using System.Text.RegularExpressions;

namespace CSharpCourse.Property.Ex02;

public class Address
{
    public string Street { get; set; }
    public string StreetNumber { get; set; }
    public string City { get; set; }

    private string _zipCode;

    // Set zip code with ordinary method

    public void SetZipCode(string newvalue)
    {
        if (ZipCodeIsValid(newvalue))
        {
            _zipCode = newvalue;
        }
    }

    // Get zip code with ordinary method

    public string GetZipCode()
    {
        return _zipCode;
    }

    // Alternative with Set property

    public string ZipCode
    {
        get
        {
            return _zipCode;
        }
        set
        {
            if (ZipCodeIsValid(value))
            {
                _zipCode = value;
            }
        }
    }

    private static bool ZipCodeIsValid(string value)
    {
        return Regex.IsMatch(value, @"^\d\d\d \d\d$");
    }

    // -------- from previous exercise:

    // Get method

    public string GetFullStreet()
    {
        return $"{Street} {StreetNumber}";
    }

    // Get using property instead

    public string FullStreet
    {
        get
        {
            return $"{Street} {StreetNumber}";
        }
    }

    // Same as above but shorter

    public string FullStreet_Shorter => $"{Street} {StreetNumber}";

}
