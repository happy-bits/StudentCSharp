// Syfte: Konstruktorer gör att det blir snabbare att skapa ett objekt med vissa egenskaper
//        och vi styr hur en bil får skapas 

namespace CSharpCourse.Classes.Ex04;

public class Solution
{
    class Car
    {
        private readonly string _color;
        private readonly int _weight;

        public Car()
        {
            _color = "white";
            _weight = 1000;
        }

        public Car(string color, int weight)
        {
            var validColors = new[] { "blue", "red", "white" };

            if (!validColors.Contains(color))
            {
                throw new ArgumentException("Invalid color");
            }

            if (weight<0 || weight > 3000)
            {
                throw new ArgumentException("Invalid weight");
            }

            _color = color;
            _weight = weight;
        }


        public string GetColor()
        {
            return _color;
        }

        public int GetWeight()
        {
            return _weight;
        }
    }

    public static void Run()
    {
        var c1 = new Car("blue", 1200); // blue  1200kg
        var c2 = new Car("red", 800);   // red    800kg
        var c3 = new Car();             // white 1000kg

        //var c4 = new Car("abcd", 1000);   // doesn't work (good)
        //var c5 = new Car("blue", 999999); // doesn't work (good)

        Console.WriteLine($"The color of car1 is {c1.GetColor()} and the weight is {c1.GetWeight()}");
        Console.WriteLine($"The color of car2 is {c2.GetColor()} and the weight is {c2.GetWeight()}");
        Console.WriteLine($"The color of car3 is {c3.GetColor()} and the weight is {c3.GetWeight()}");

    }
}
