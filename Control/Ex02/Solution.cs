namespace CSharpCourse.Control.Ex02;

public class Solution
{
    public static void RepeatNameWithWhile()
    {
        Console.Write("Enter your name: ");
        string yourName = Console.ReadLine()!;

        Console.Write("Times to repeat: ");
        int repeat = int.Parse(Console.ReadLine()!);

        int counter = 1;

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine();

        while (counter <= repeat)
        {
            Console.WriteLine($"Your name is {yourName}");
            counter++;
        }

    }

}
