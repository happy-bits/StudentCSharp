namespace CSharpCourse.Property.DemoGetter;

public class Demo4
{
    // Smidigare att bara använda en pil

    public class Phone
    {
        public decimal Price { get; set; }
        public decimal VAT => Price * 0.25M;
        public decimal TotalPrice => Price + VAT;
    }

    public static void Run()
    {
        var telefon = new Phone
        {
            Price = 1000
        };
        Console.WriteLine($"Momsen för telefonen är {telefon.VAT}kr");
        Console.WriteLine($"Total kostnad för telefonen är {telefon.TotalPrice}kr");
    }
}
