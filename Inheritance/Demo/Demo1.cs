// Purpose: shows inheritance (of properties)
namespace CSharpCourse.Inheritance.Demo;


public class Demo1
{
    // Create Animal class with properties Name and Weight
    
    class Animal
    {
        public string? Name { get; set; }
        public decimal Weight { get; set; }
    }

    // Create FurSize enum (short and long)
    enum FurSize
    {
        Short, Long
    }

    // Create Mammal class with FurSize and NrOfTeeth. Mammal is an Animal

    class Mammal : Animal
    {
        public FurSize FurSize { get; set; }
        public int NrOfTeeth { get; set; }
    }

    // Create Cat with prop FavoriteFish. Cat is a Mammal.

    class Cat : Mammal
    {
        public string? FavoriteFish { get; set; }
    }

    // Create Dog with BarkLevel. Dog is a Mammal

    class Dog : Mammal
    {
        public int BarkLevel { get; set; }
    }

    // Create a Bird. Bird is an Animal

    class Bird: Animal
    {
    }

    public static void Run()
    {
        // Create a Mammal. Try to add as many values as possible (FurSize, NrOfTeeth etc)

        var jerboa = new Mammal();
        jerboa.Name = "Jerry";
        jerboa.FurSize = FurSize.Short;
        jerboa.Weight = 80;
        jerboa.NrOfTeeth = 2;
        //jerboa.FavoriteFish = "Salmon"; // don't work
        //jerboa.BarkLevel = 5; // don't work

        // Same with Dog

        var myDog = new Dog();
        myDog.Name = "Pluto";
        myDog.FurSize = FurSize.Short;
        myDog.Weight = 8000;
        myDog.NrOfTeeth = 4;
        //myDog.FavoriteFish = "Salmon"; // don't work
        myDog.BarkLevel = 5;

        // Same with Cat

        var myCat = new Cat();
        myCat.Name = "Musse";
        myCat.FurSize = FurSize.Long;
        myCat.Weight = 5300;
        myCat.NrOfTeeth = 4;
        myCat.FavoriteFish = "Salmon";
        //myCat.BarkLevel = 5; // don't work

        // Same with Bird

        var myBird = new Bird();
        myBird.Name = "Goosy";
        myBird.Weight = 4500;
        //myBird.FurSize = FurSize.Long; // don't work
        //myBird.NrOfLegs = 4; // don't work
        //myBird.FavoriteFish = "Salmon"; // don't work
        //myBird.BarkLevel = 5; // don't work


    }
}
