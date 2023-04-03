namespace CSharpCourse.Methods.Ex01;

public class Solution_NoMethods
{
    public static void Run()
    {
        // Get list of names from user

        Console.Write("Enter a list of names: ");
        string listOfNames = Console.ReadLine()!;

        // Create list

        string[]? list = listOfNames?.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

        // Report to user

        Console.ForegroundColor = ConsoleColor.Green;
        if (list == null || list.Length == 0)
        {
            Console.WriteLine("No people in the list");
        }
        else
        {
            foreach (string person in list)
            {
                Console.WriteLine($"***SUPER-{person.ToUpper()}***");
            }
        }
        Console.ForegroundColor = ConsoleColor.White;
    }

}
