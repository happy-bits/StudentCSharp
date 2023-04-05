namespace CSharpCourse.Interfaces.Demo;

public class Demo1
{
    // yxa, svärd, bröd, mus, häst, djur

    // Axe              IPackable, IDangerous
    // Sword            IPackable, IDangerous
    // Bread            IPackable
    // Mouse            IPackable, Animal 
    // Horse            Animal

    // IPackable        PutInBag
    // IDangerous       GiveDamage

    // PutStuffInBag    Förväntar sig en Lista av IPackable

    interface IPackable
    {
        void Pack();
    }

    interface IDangerous
    {
        void GiveDamage();
    }

    class Animal
    {
        public void SayHello()
        {
        }
    }

    class Axe : IPackable, IDangerous
    {
        public void Pack()
        {
        }

        public void GiveDamage()
        {
        }
    }

    class Sword : IPackable, IDangerous
    {
        public void Pack()
        {
        }

        public void GiveDamage()
        {
        }
    }

    class Bread : IPackable
    {
        public void Pack()
        {
        }
    }

    class Mouse : Animal, IPackable
    {
        public void Pack()
        {
        }
    }


    class Horse : Animal
    {

    }

    static void PutInBag(IPackable x)
    {
        x.Pack();
    }

    private static void PutStuffInBag(List<IPackable> stuff)
    {
        foreach (IPackable item in stuff)
        {
            item.Pack();
        }
    }

    static void GreetToAnimal(Animal a)
    {
        a.SayHello();
    }

    static void DoDamageWith(IDangerous dangerous)
    {
        dangerous.GiveDamage();
    }
    public static void Run()
    {

        GreetToAnimal(new Animal());
        //Greet(new Axe());   // Shouldn't work
        //Greet(new Bread()); // Shouldn't work
        GreetToAnimal(new Horse());
        GreetToAnimal(new Mouse());
        //Greet(new Sword()); // Shouldn't work

        //PutInBag(new Animal());  // Shouldn't work 
        PutInBag(new Axe());
        PutInBag(new Bread());
        //PutInBag(new Horse());  // Shouldn't work
        PutInBag(new Mouse());
        PutInBag(new Sword());

        //DoDamageWith(new Animal());  // Shouldn't work 
        DoDamageWith(new Axe());
        //DoDamageWith(new Bread()); // Shouldn't work
        //DoDamageWith(new Horse()); // Shouldn't work
        //DoDamageWith(new Mouse()); // Shouldn't work
        DoDamageWith(new Sword());


        List<IPackable> stuff = new List<IPackable>
        {
            new Axe(),
            new Bread(),
            new Bread(),
            new Mouse(),
            new Sword(),
            new Sword()
        };
        PutStuffInBag(stuff);

        List<IDangerous> d = new List<IDangerous>();
        d.Add(new Axe());
        //d.Add(new Bread()); // går ej
        //d.Add(new Mouse()); // går ej
        d.Add(new Sword());
        //d.Add(new Animal()); // går ej

        AttackWith(d);
    }

    private static void AttackWith(List<IDangerous> d)
    {
        foreach (IDangerous item in d)
        {
            item.GiveDamage();
        }
    }
}
