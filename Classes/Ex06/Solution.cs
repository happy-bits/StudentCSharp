// Syfte: Auto property
// Fördel: kan enkelt sätta och hämta värden
// Nackdel: har lite kontroll vad för värden som sätts

namespace CSharpCourse.Classes.Ex06;

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

            if (weight < 0 || weight > 3000)
            {
                throw new ArgumentException("Invalid weight");
            }

            _color = color;
            _weight = weight;
        }

        public string Color => _color;

        public int Weight => _weight;

        public string? Note { get; set; }
    }

    public static void Run()
    {
        var c1 = new Car("blue", 1200);
        var c2 = new Car("red", 800);  
        var c3 = new Car();            

        Console.WriteLine($"The color of car1 is {c1.Color} and the weight is {c1.Weight}");
        Console.WriteLine($"The color of car2 is {c2.Color} and the weight is {c2.Weight}");
        Console.WriteLine($"The color of car3 is {c3.Color} and the weight is {c3.Weight}");

        c1.Note = "A nice car";
        c2.Note = "Very rusty!";

        Console.WriteLine($"The note of car1 is {c1.Note}");
        Console.WriteLine($"The note of car2 is {c2.Note}");
        Console.WriteLine($"The note of car3 is {c3.Note}");

    }
}
