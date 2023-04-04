namespace CSharpCourse.Property.DemoGetter;

public class Demo3
{

    // Samma sak men med properties

    public class Phone
    {
        public decimal Price { get; set; }

        public decimal VAT
        {
            get 
            { 
                return Price * 0.25M; 
            }
        }

        public decimal TotalPrice
        {
            get
            { 
                return Price + VAT; 
            }
        }
    }
    
    public static void Run()
    {
        var telefon = new Phone();
        telefon.Price = 1000;
        Console.WriteLine($"Momsen för telefonen är {telefon.VAT}kr");
        Console.WriteLine($"Total kostnad för telefonen är {telefon.TotalPrice}kr");
    }
}
