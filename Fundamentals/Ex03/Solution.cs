namespace CSharpCourse.Fundamentals.Ex03;

public class Solution
{
    public static void FormatStringsInDiffentWays()
    {
        Console.Write("Enter fruit 1: ");
        string fruit1 = Console.ReadLine()!;

        Console.Write("Enter fruit 2: ");
        string fruit2 = Console.ReadLine()!;

        Console.Write("Enter fruit 3: ");
        string fruit3 = Console.ReadLine()!;

        string message1 = "You entered three fruits: " + fruit1 + ", " + fruit2 + ", " + fruit3 + "!";          // concatenation
        string message2 = string.Format("You entered three fruits: {0}, {1}, {2}!", fruit1, fruit2, fruit3);    // placeholders
        string message3 = $"You entered three fruits: {fruit1}, {fruit2}, {fruit3}!";                           // interpolated

        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(message1);
        Console.WriteLine(message2);
        Console.WriteLine(message3);

        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine();
    }
}
