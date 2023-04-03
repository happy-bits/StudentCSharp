namespace CSharpCourse.Methods.Ex02;

public class Solution
{
    public static void Run()
    {
        string response = GetInputFromUser();

        string[] peopleArray = CreateArrayOfPeople(response);

        CleanUpArray(peopleArray);

        RespondToUser(peopleArray);
    }

    private static string GetInputFromUser()
    {
        Write("Enter a list of names: ");
        string answer = Console.ReadLine()!;
        return answer;
    }

    private static string[] CreateArrayOfPeople(string response)
    {
        if (string.IsNullOrWhiteSpace(response))
            return new string[] { };

        string[] list = response.Split(',');

        return list;
    }

    private static void RespondToUser(string[] peopleArray)
    {
        if (peopleArray.Length == 0)
        {
            WriteGreen("No people in the list");
            return;
        }

        foreach (string person in peopleArray)
        {
            WriteGreen($"***SUPER-{person.ToUpper()}***");
        }
    }

    private static void CleanUpArray(string[] peopleArray)
    {
        for (var i = 0; i < peopleArray.Length; i++)
        {
            peopleArray[i] = peopleArray[i].Trim();
        }
    }

    private string[] CleanUpArray_Alternative(string[] list)
    {
        var x = new List<string>();

        foreach (var element in list)
        {
            var cleanedElement = element.Trim();
            x.Add(cleanedElement);
        }

        return x.ToArray();
    }

    private static void WriteGreen(string text)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(text);
    }

    private static void Write(string text)
    {
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write(text);
    }
}
