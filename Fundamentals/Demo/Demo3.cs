namespace CSharpCourse.Fundamentals.Demo;

public class Demo3
{
    public static void Run()
    {
        Console.Write("Enter your height: ");
        string answer = Console.ReadLine()!;

        decimal height = decimal.Parse(answer);

        if (height<0)
            Console.WriteLine("You can't have negative height");
        else if (height>200)
            Console.WriteLine("You are higher than 2m" );
        else
            Console.WriteLine("You are lower than 2m");
    }
}
