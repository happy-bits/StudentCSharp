namespace CSharpCourse.Linq.Ex01;


public class Solution_Compact_Exercise
{
    public void Run()
    {
        string[] rows = ReadTvShowFile();
        IEnumerable<Show> allShows = ParseTvShows(rows);
        DisplayInfoAboutShows(allShows);
    }

    private static string[] ReadTvShowFile()
    {
        return File.ReadAllLines(@"Linq\Ex01\tv-data.txt");
    }

    private void DisplayInfoAboutShows(IEnumerable<Show> allShows)
    {
        /*
         todo: Create this method


        Hint: solve this by calling DisplayShows or DisplayYesOrNo. Like this:

            DisplayShows("Alla titlar", ...)
            DisplayYesOrNo("Finns programmet 'Kulturnyheterna'?", ...)


         */

        throw new NotImplementedException();
    }

    private static void DisplayYesOrNo(string header, bool result)
    {
        Header(header);

        if (result)
            Console.WriteLine("Ja");
        else
            Console.WriteLine("Nej");
    }

    private static void DisplayShows(string header, IEnumerable<string> list)
    {
        Header(header);

        Console.ForegroundColor = ConsoleColor.White;

        foreach (var s in list)
            Console.WriteLine(s);
    }

    private static void DisplayShows(string header, IEnumerable<Show> shows)
    {
        Header(header);

        Console.ForegroundColor = ConsoleColor.White;

        foreach (var show in shows)
            Console.WriteLine(show.Channel.PadRight(4) + " " + show.StartAt + " " + show.Title);
    }

    private static IEnumerable<Show> ParseTvShows(string[] rows) => rows.Select(line => new Show
    {
        Channel = line.Split('*')[0],
        StartAt = TimeSpan.Parse(line.Split('*')[1]),
        Title = line.Split('*')[2],
    });

    private static void Header(string text)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine();
        Console.WriteLine(text);
        Console.WriteLine();
    }

}
