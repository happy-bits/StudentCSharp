
using ConsoleUtilities;

namespace CSharpCourse.Inheritance.Ex01;

public class Solution
{
    readonly ConsoleCompanion cc = new ConsoleCompanion();

    abstract class Product
    {
        public string Id { get; set; } = "";
        public decimal Price { get; set; }
        public string Description { get; set; } = "";
        public bool InStore { get; set; }

        public List<string> Bullets { get; set; }= new List<string>();

        public string GetBulletsAsString()
        {
            return string.Join("\n", Bullets.Select(x => "* " + x));
        }

        public void ApplyDiscount()
        {
            Price *= 0.8M;
        }

        // Alternative with property
        // public string BulletsAsString => string.Join("\n", Bullets.Select(x => "* " + x));

    }

    class Lightbulb : Product
    {
        public decimal LightOutput { get; set; } // lumen
    }

    class Battery : Product
    {
        public string? Type { get; set; } // batterityp
    }

    public void Run()
    {
        // https://www.clasohlson.com/se/Dimbar-klotlampa-LED-E27-Clas-Ohlson/36-7224
        var p1 = new Lightbulb
        {
            Id = "36-7224",
            Description = "Dimbar klotlampa LED E27",
            Price = 39.9M,
            InStore = false,
            Bullets = new List<string>
            {
                "Dimringsbar och med klart glas",
                "Premium Classic",
                "Livslängd upp till 15 000 timmar",
                "Varmvit (2700 K)"
            }
        };

        // https://www.clasohlson.com/se/Alkaliskt-batteri-Varta-Longlife-Power-24-pack/36-5126
        var p2 = new Battery
        {
            Id = "36-5126",
            Description = "Alkaliskt batteri Varta Longlife",
            Price = 99.9M,
            InStore = true,
            Bullets = new List<string>
            {
                "Storpack, 24 st. i praktisk ask.",
                "För energislukande produkter",
                "High Energy"
            }
        };

        p1.LightOutput = 136;
        //p2.LightOutput = 666; // <---- this shouldn't work

        //p1.Type = "...."; // <---- this shouldn't work
        p2.Type = "AA/LR06";

        //var test = new Product(); // <---- this shouldn't work

        var products = new List<Product>();
        products.Add(p1);
        products.Add(p2);

        cc.WriteLineGreen("\nAlla produkter\n");
        ShowProductInfo(products);

        ApplyDiscountOn(products);

        cc.WriteLineGreen("\nMed rabatt\n");
        ShowProductInfo(products);

        cc.WriteLineGreen("\nSäljtexter\n");
        SalesTexts(products);

        cc.WriteLineGreen("\nInfo om lampor\n");
        ShowInfoAboutAllLightbulbs(products);

    }

    private void ShowProductInfo(List<Product> products)
    {
        foreach (var product in products)
        {
            cc.Columns(product.Id, product.Price, product.InStore, product.Description);
        }
    }

    private static void ApplyDiscountOn(List<Product> products)
    {
        foreach (var product in products)
        {
            product.ApplyDiscount();
        }
    }

    private void SalesTexts(List<Product> products)
    {
        foreach (var product in products)
        {
            cc.WriteLineDark(product.Description);
            cc.WriteLine(product.GetBulletsAsString());
            cc.Space();
        }
    }

    private void ShowInfoAboutAllLightbulbs(List<Product> products)
    {
        foreach (Product product in products)
        {
            var lightbulb = product as Lightbulb;
            if (lightbulb == null)
                continue;

            cc.WriteLineDark(lightbulb.Description);
            cc.WriteLine($"Light output: {lightbulb.LightOutput} lumen");
        }
    }

    // Alternative with "Where"
    private void ShowInfoAboutAllLightbulbs_Where(List<Product> products)
    {
        foreach (Lightbulb lightbulb in products.Where(x => x is Lightbulb))
        {
            cc.WriteLineDark(lightbulb.Description);
            cc.WriteLine($"Light output: {lightbulb.LightOutput} lumen");
        }
    }

    // Alternative with "OfType"
    private void ShowInfoAboutAllLightbulbs_OfType(List<Product> products)
    {
        foreach (Lightbulb lightbulb in products.OfType<Lightbulb>())
        {
            cc.WriteLineDark(lightbulb.Description);
            cc.WriteLine($"Light output: {lightbulb.LightOutput} lumen");
        }
    }

}
