// Purpose: show virtual methods

namespace CSharpCourse.Inheritance.Demo;

public class Demo4
{

    class Mammal 
    {
        public string? Name { get; set; }
        public int Age { get; set; }
        
        // virtual must have an implementation (this can't be "override" since it doesn't have a base class with SayHi)
        public virtual string SayHi() 
        {
            return $"My name is {Name} and I'm a mammal";
        }
			
    }

    class Cat : Mammal
    {
        public string? FavoriteFish { get; set; }

        // you may override a virtual method (but you don't have to)
        public override string SayHi()      
        {
            return "I'm a cat and my favorite fish is "+FavoriteFish;
            //return $"{base.SayHi()}. I'm a cat and my favorite fish is {FavoriteFish}";

        }
    }

    class Dog : Mammal
    {
        public int BarkLevel { get; set; }
    }

    class Pig: Mammal
    {

    }

    public static void Run()
    {
        var pluto = new Dog();
        pluto.Name = "Pluto";
        pluto.BarkLevel = 3;

        var musse = new Cat();
        musse.Name = "Musse";
        musse.FavoriteFish = "salmon";

        var pig = new Pig();
        pig.Name = "Piggy";

        Console.WriteLine(pluto.SayHi());
        Console.WriteLine(musse.SayHi());
        Console.WriteLine(pig.SayHi());

        // Use the debugger to check the values of s1 and s2 above
    }


}
