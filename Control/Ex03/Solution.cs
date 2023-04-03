namespace CSharpCourse.Control.Ex03;

public class Solution
{

    public static void RepeatNameWithFor()
    {

        Console.Write("Enter your name: ");
        string yourName = Console.ReadLine()!;

        Console.Write("Times to repeat: ");
        int repeat = int.Parse(Console.ReadLine()!);

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine();

        for (int counter = 0; counter < repeat; counter++)
        {
            Console.WriteLine($"Your name is {yourName}");
        }

    }
}
