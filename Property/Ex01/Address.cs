namespace CSharpCourse.Property.Ex01;

public class Address
{
    public string Street { get; set; } = "";
    public string StreetNumber { get; set; } = "";
    public string City { get; set; } = "";
    public string ZipCode { get; set; } = "";

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
