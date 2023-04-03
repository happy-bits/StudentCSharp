namespace CSharpCourse.Control.Ex04;

public class Solution
{
    public static void SplitAndForeach()
    {
        Console.Write("Enter names in a list (like Maria,Peter,Lisa): ");
        string names = Console.ReadLine()!;

        string[] nameList = names.Split(",", StringSplitOptions.RemoveEmptyEntries);
        //string[] nameList = names.Split(",");

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine();

        foreach (string name in nameList)
        {
            Console.WriteLine($"{name} Andersson");
        }
    }
}
