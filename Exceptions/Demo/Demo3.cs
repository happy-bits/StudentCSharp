namespace CSharpCourse.Exceptions.Demo;

public class Demo3
{
    public static void Run()
    {
        CreateTextFile(@"c:\aaaaaaaa.txt");
    }

    private static void CreateTextFile(string filename)
    {
        try
        {
            File.CreateText(filename);

        }
        catch (ArgumentException)
        {
            Console.WriteLine("Något fel på filnamnet!");
        }
        catch (UnauthorizedAccessException)
        {
            Console.WriteLine("Du har inte rättighet att skapa en fil här!");
        }
    }
}
