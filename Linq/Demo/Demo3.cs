namespace CSharpCourse.Linq.Demo;

public class Demo3
{
    public void Run()
    {
        var people = new List<Person>
        {
            new Person ("Ludvig", 55 ),
            new Person ("Alice", 15 ),
            new Person ("Fred", 30 ),
            new Person ("Zelda",  45)
        };

        Func<Person, bool> filter;

        filter = IsChild;

        foreach (Person p in people.Where(filter))
        {
            Console.WriteLine($"* {p.FirstName}");
        }

        // Vi kan i efterhand ångra oss och byta ut filterfunktionen till något annat:

        filter = IsOld;

        foreach (Person p in people.Where(filter))
        {
            Console.WriteLine($"* {p.FirstName}");
        }

    }
    private bool IsChild(Person p)
    {
        return p.Age < 18;
    }

    private bool IsOld(Person p)
    {
        return p.Age > 50;
    }
}
