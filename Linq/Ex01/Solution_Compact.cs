/* Syfte: samma som TvShows men fler metoder och mer kompakt */

namespace CSharpCourse.Linq.Ex01;


public class Solution_Compact
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
        DisplayShows("Alla titlar", allShows.Select(s=>s.Title));
        DisplayShows("Program som börjar senare än kl 21 - med Linq", allShows.Where(show => show.StartAt.Hours >= 21));
        DisplayShows("Program från svt2 i kronologisk ordning", allShows.Where(x => x.Channel == "SVT2").OrderBy(x => x.StartAt));
        DisplayYesOrNo("Finns programmet 'Kulturnyheterna'?", allShows.Any(x => x.Title == "Kulturnyheterna"));
        DisplayYesOrNo("Finns programmet 'Ensam pappa söker'?", allShows.Any(x => x.Title == "Ensam pappa söker"));
        DisplayShows("Alla program som börjar kl 20.00", allShows.Where(x => x.StartAt.TotalHours == 20));
        DisplayShows("Alla programnamn med stora bokstäver", allShows.Select(x => x.Title.ToUpper()));
        DisplayShows("Alla kanaler", allShows.Select(x => x.Channel).Distinct());
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
