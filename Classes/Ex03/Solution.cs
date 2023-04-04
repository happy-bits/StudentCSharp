// Syfte: skapa en bil-klass som innehåller fler bil-egenskaper (både färg och vikt)

namespace CSharpCourse.Classes.Ex03;

public class Solution
{
    class Car
    {
        private string _color="";
        private int _weight;

        public void SetColor(string color)
        {
            _color = color;
        }

        public string GetColor()
        {
            return _color;
        }

        public void SetWeight(int weight)
        {
            _weight = weight;
        }

        public int GetWeight()
        {
            return _weight;
        }
    }

    public static void Run()
    {
        // Create three cars. 
        // Set color and weight of car1 and car2
        // Print info about the cars

        var c1 = new Car();
        var c2 = new Car();
        var c3 = new Car();

        c1.SetColor("blue");
        c1.SetWeight(1200);

        c2.SetColor("red");
        c2.SetWeight(800);

        Console.WriteLine($"The color of car1 is {c1.GetColor()} and the weight is {c1.GetWeight()}");
        Console.WriteLine($"The color of car2 is {c2.GetColor()} and the weight is {c2.GetWeight()}");
        Console.WriteLine($"The color of car3 is {c3.GetColor()} and the weight is {c3.GetWeight()}");

    }
}
