namespace CSharpCourse.Fundamentals.Demo;

public class Demo2
{
    public static void Run()
    {
        Console.Write("Enter your height: ");
        string answer = Console.ReadLine()!;
        decimal height = decimal.Parse(answer);

        decimal meters = height / 100;
        string response = "You are " + meters + "m long";               // "Concatination"
        //string response = $"You are {meters}m long";                  // "Interpolated"
        //string response = string.Format("You are {0}m long", meters); // "Placeholders"
        
        Console.WriteLine(response);
    }
}
