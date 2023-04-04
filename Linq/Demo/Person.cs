namespace CSharpCourse.Linq.Demo;

public class Person
{
    public Person(string firstname, int age)
    {
        FirstName = firstname;
        Age = age;
    }

    public int Age { get; }
    public string FirstName { get; }
}
