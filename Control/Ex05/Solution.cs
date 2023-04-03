namespace CSharpCourse.Control.Ex05;

public class Solution
{

    public static void SplitAndForeach_WithBreak()
    {
        Console.Write("Enter names in a list (like Maria,Peter,Lisa): ");
        string names = Console.ReadLine()!;
        string[] nameList = names.Split(",", StringSplitOptions.RemoveEmptyEntries);

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine();

        foreach (string name in nameList)
        {
            if (name == "Zelda")
            {
                break;
            }

            Console.WriteLine($"{name} Andersson");
        }
    }
}
