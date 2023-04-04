namespace CSharpCourse.Property.DemoGetter;

public class Demo1
{
    // Bad solution 

    class Phone
    {
        public decimal Price { get; set; }
        public decimal VAT { get; set; }            // bad: this can be set to wrong value
        public decimal TotalPrice { get; set; }     // bad: this can be set to wrong value
    }

    public static void Run()
    {
        var telefon = new Phone();
        telefon.Price = 1000;
        telefon.VAT = 250;
        telefon.TotalPrice = 1250;
        Console.WriteLine($"Total price for the phone: {telefon.TotalPrice}");
        
    }
}
