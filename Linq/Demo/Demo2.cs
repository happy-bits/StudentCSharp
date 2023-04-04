/* 
   Visar hur man kan lösa vissa uppgifter lättare med LINQ:
   - Filtrera en lista av "Person"
 */

namespace CSharpCourse.Linq.Demo;


public class Demo2
{
    public static void Run()
    {
        var people = new List<Person>
        {
            new Person ("Ludvig", 55 ),
            new Person ("Alice", 28 ),
            new Person ("Fred", 30 ),
            new Person ("Zelda",  45)
        };

        Header("Utan linq:");

        IEnumerable<Person> result = PeopleOlderThan32(people);

        Console.WriteLine("Personer som är äldre än 32");
        foreach (Person p in result)
        {
            Console.WriteLine("* " + p.FirstName);
        }

        Header("Med linq:");

        Console.WriteLine("Personer som är äldre än 32");

        IEnumerable<Person> result2 = people.Where(p => p.Age > 32);

        foreach (Person p in result2)
        {
            Console.WriteLine("* " + p.FirstName);
        }

        Console.WriteLine();


        // Use LINQ statement to create a list with these two elements 
        //  "Ludwig is 55"
        //  "Zelda is 45"
        
        IEnumerable<string> result3 = people
            .Where(p => p.Age > 32)
            .Select(p=> $"{p.FirstName} is {p.Age} years old");

    }

    private static IEnumerable<Person> PeopleOlderThan32(IEnumerable<Person> list)
    {
        var result = new List<Person>();
        foreach (var p in list)
        {
            if (p.Age > 32)
                result.Add(p);
        }
        return result;
    }

    private static void Header(string text)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("\n" + text.ToUpper() + "\n");
        Console.ForegroundColor = ConsoleColor.White;
    }
}
