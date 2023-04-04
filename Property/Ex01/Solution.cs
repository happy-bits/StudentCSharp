namespace CSharpCourse.Property.Ex01;

public class Solution
{
    public static void Run()
    {
        Address address = new Address
        {
            Street = "Långa gatan",
            StreetNumber = "13B",
            City = "Sundsvall",
            ZipCode = "111 22"
        };

        Console.WriteLine("Street".PadRight(30) + address.Street);
        Console.WriteLine("StreetNumber".PadRight(30) + address.StreetNumber);
        Console.WriteLine("City".PadRight(30) + address.City);
        Console.WriteLine("ZipCode".PadRight(30) + address.ZipCode);
        Console.WriteLine("FullStreet".PadRight(30) + address.FullStreet);
    }
}
