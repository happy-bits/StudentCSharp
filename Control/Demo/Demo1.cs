namespace CSharpCourse.Control.Demo;

public class Demo1
{
    public static void Run()
    {
        while (true)
        {
            Console.WriteLine("Enter your favorite color: ");
            string answer = Console.ReadLine()!;

            if (answer == "green" || answer == "blue" || answer == "red")
            {
                Console.WriteLine($"You like the color {answer}");
                break;
            }

            Console.WriteLine("I don't know that color, try again");
        }
    }
}
