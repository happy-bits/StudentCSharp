namespace CSharpCourse.Property.DemoSetter;

public class Demo3
{
    // Samma som Demo2 men med properties

    class Tshirt
    {
        private decimal _discount=0;

        public decimal Price { get; set; }

        public decimal Discount
        {
            get => _discount;
            set
            {
                if (value >= 0 && value <= 1)
                {
                    _discount = value;
                }
            }
        }

        public decimal PriceWithDiscount => Price * (1 - Discount); 

    }

    public static void Run()
    {
        var t = new Tshirt();
        t.Price = 400;
        t.Discount = 0.3M;
        t.Discount = 123M; // här kommer inget ske

        Console.WriteLine($"Priset för tshirten med rabatt är :{t.PriceWithDiscount}");

    }
}
