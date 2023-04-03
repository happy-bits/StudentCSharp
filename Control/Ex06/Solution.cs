namespace CSharpCourse.Control.Ex06;

public class Solution
{
    public static void IfStatement()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine()!);

        string message;
        if (number > 20)
        {
            message = "The number is higher than 20";
        }
        else
        {
            message = "Lower or equal to 20";
        }
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine();
        Console.WriteLine(message);
    }

}
