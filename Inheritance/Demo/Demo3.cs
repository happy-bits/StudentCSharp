// Purpose: show the need of abstract classes

namespace CSharpCourse.Inheritance.Demo;

public class Demo3
{

    abstract class Mammal 
    {
        public string? Name { get; set; }
        public int Age { get; set; }
        
        // We wan't this method to exist, but we don't know what will happen when it will run. The subclass have to decide (implement)

        public abstract double AgeInHumanYears();    
    }

    class Cat : Mammal
    {
        public string? FavoriteFish { get; set; }

        public override double AgeInHumanYears()
        {
            return Age * 5;
        }
    }

    // Create Dog class. AgeInHumanYears*7

    class Dog : Mammal
    {
        public int BarkLevel { get; set; }
        public override double AgeInHumanYears()
        {
            return Age * 7;
        }
    }

    //  Try this, what will happen?
    //  class Pig: Mammal
    //  {
    //  }

    public static void Run()
    {
        var pluto = new Dog();
        pluto.Name = "Pluto";
        pluto.Age = 10;

        var musse = new Cat();
        musse.Name = "Musse";
        musse.Age = 10;

        // Create method DisplayInHumanYears that write info about a Mammal (including ageinhumanyears)
        DisplayInfoAboutMammal(pluto);
        DisplayInfoAboutMammal(musse);

    }

    private static void DisplayInfoAboutMammal(Mammal m)
    {
        Console.WriteLine($"{m.Name} is {m.Age} which in human years is {m.AgeInHumanYears()}");
    }
}
