namespace CSharpCourse.Fundamentals.Demo;

public class Demo1
{
    public static void Run()
    {
        Console.Write("Enter your height: ");
        string answer = Console.ReadLine()!;
        Console.WriteLine("You are " + answer + "cm long");
    }
}
