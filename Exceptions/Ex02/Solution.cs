using ConsoleUtilities;

namespace CSharpCourse.Exceptions.Ex02;

public class Solution
{
    public static void Run()
    {
        ConsoleCompanion cc = new ConsoleCompanion();

        while (true)
        {
            string filename = cc.AskForString("Enter a file name:");
            bool success = CreateTextfile(filename);

            if (success)
                break;

        }
    }

    private static bool CreateTextfile(string filename)
    {
        ConsoleCompanion cc = new ConsoleCompanion();
        try
        {
            File.CreateText(filename);
            Console.WriteLine($"The file '{filename}' is now created");
            return true;
        }
        catch (UnauthorizedAccessException)
        {
            cc.WriteLineRed("You're not authorized to create this file");
        }
        catch (DirectoryNotFoundException)
        {
            cc.WriteLineRed("Directory not found");
        }
        catch (IOException)
        {
            cc.WriteLineRed("Input output exception");
        }
        catch (Exception)
        {
            cc.WriteLineRed($"Something strange happened");
        }
        return false;
    }

}
