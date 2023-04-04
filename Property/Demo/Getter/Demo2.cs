namespace CSharpCourse.Property.DemoGetter;

public class Demo2
{
    // Bättre för nu beräknas värdena av moms och totalpris

    class Phone
    {
        public decimal Price { get; set; }

        public decimal GetVAT()
        {
            return Price * 0.25M;
        }

        public decimal GetTotalPrice()
        {
            return Price + GetVAT();
        }
    }

    public static void Run()
    {
        var telefon = new Phone();
        telefon.Price = 1000;
        Console.WriteLine($"Momsen för telefonen är {telefon.GetVAT()}kr");
        Console.WriteLine($"Total kostnad för telefonen är {telefon.GetTotalPrice()}kr");
    }
}
