/*
 Syfte: hyfsat verkligt exempel 

 Läs in en textfil och vrid och vänd på datan:
 - Filtrera
 - Manipulera
 - Sortera

 I detta fall en lista med tv-shower
 
 */

namespace CSharpCourse.Linq.Ex01;


public class Solution
{
    public static void Run()
    {
        string[] rows = ReadTvShowFile();

        //List<Show> allShows = ParseTvShows(rows);

        // Extrauppgift, lös ParseTvShow med ett linq-uttryck (one-liner)
        List<Show> allShows = ParseTvShows_Linq(rows);

        DisplayInfoAboutShows(allShows);

        // Extrauppgift
        //MoreInfo(allShows);

    }

    private void MoreInfo(List<Show> allShows)
    {
        foreach (string s in GetNrOfShowsPerChannel(allShows))
        {
            Console.WriteLine(s);
        }

    }

    // Extrauppgift

    private static IEnumerable<string> GetNrOfShowsPerChannel(List<Show> allShows)
    {
        return allShows.GroupBy(s => s.Channel).Select(s => $"Kanal {s.Key} har {s.Count()} programm");
    }

    private static string[] ReadTvShowFile()
    {
        return File.ReadAllLines(@"Linq\Ex01\tv-data.txt");
    }

    private static void DisplayInfoAboutShows(List<Show> allShows)
    {
        // Alla programtitlar

        Header("Alla titlar");

        foreach (string title in allShows.Select(s => s.Title))
        {
            Console.WriteLine(title);
        }

        // Alla program som börjar senare än 21.00 - alternativ I

        Header("Program som börjar senare än kl 21");

        var laterThan21 = new List<Show>();

        foreach (Show show in allShows)
        {
            if (show.StartAt.Hours >= 21)
            {
                laterThan21.Add(show);
            }
        }

        foreach (Show show in laterThan21)
        {
            WriteInfoAboutShow(show);
        }

        // Alla program som börjar senare än 21.00 - alternativ II (Linq)

        Header("Program som börjar senare än kl 21 - med Linq");

        foreach (Show show in allShows.Where(show => show.StartAt >= TimeSpan.FromHours(21)))
        //foreach (Show show in allShows.Where(show => show.StartAt >= TimeSpan.Parse("21:00")))
        //foreach (Show show in allShows.Where(show => show.StartAt.Hours >= 21))
        {
            WriteInfoAboutShow(show);
        }

        // Alla program som börjar senare än 21.00 - alternativ III (Linq och foreach)

        Header("Program som börjar senare än kl 21 - med Linq och foreach");

        allShows.Where(show => show.StartAt.Hours >= 21).ToList().ForEach(WriteInfoAboutShow);

        // Program från SVT2 i kronologisk ordning

        Header("Program från svt2 i kronologisk ordning");

        foreach (Show show in allShows.Where(x => x.Channel == "SVT2").OrderBy(x => x.StartAt))
        {
            WriteInfoAboutShow(show);
        }

        Header("Finns programmet 'Kulturnyheterna'?");

        if (allShows.Any(x => x.Title == "Kulturnyheterna"))
            //if (allShows.Where(x=>x.Title=="Kulturnyheterna").Count() > 0) 
            Console.WriteLine("Ja");
        else
            Console.WriteLine("Nej");

        Header("Finns programmet 'Kulturnyheterna'? - oneliner");

        Console.WriteLine(allShows.Any(x => x.Title == "Kulturnyheterna") ? "Ja" : "Nej");

        Header("Finns programmet 'Ensam pappa söker'?");

        if (allShows.Any(x => x.Title == "Ensam pappa söker"))
            Console.WriteLine("Ja");
        else
            Console.WriteLine("Nej");

        Header("Alla program som börjar kl 20.00");

        foreach (Show show in allShows.Where(x => x.StartAt.TotalHours == 20))
        //foreach (Show show in allShows.Where(x => x.StartAt == new TimeSpan(20,0,0)))
        {
            WriteInfoAboutShow(show);
        }

        Header("Alla programnamn med stora bokstäver");

        foreach (string loudTitle in allShows.Select(x => x.Title.ToUpper()))
        {
            Console.WriteLine(loudTitle);
        }

        // Alla kanaler
        Header("Alla kanaler");

        foreach (string channel in allShows.Select(x => x.Channel).Distinct())
        {
            Console.WriteLine(channel);
        }
    }

    // Extrauppgift
    private static List<Show> ParseTvShows_Linq(string[] rows)
    {
        return rows.Select(line => new Show
        {
            Channel = line.Split('*')[0],
            StartAt = TimeSpan.Parse(line.Split('*')[1]),
            Title = line.Split('*')[2],
        }).ToList();
    }

    private List<Show> ParseTvShows(string[] rows)
    {
        var allShows = new List<Show>();

        foreach (string line in rows)
        {
            /*
               "line" kan t.ex se ut såhär:
               SVT1*22:00*Fatta Sveriges demokrati
            */
            string[] splittedLine = line.Split('*');

            var show = new Show
            {
                Channel = splittedLine[0],
                StartAt = TimeSpan.Parse(splittedLine[1]),
                Title = splittedLine[2],
            };

            allShows.Add(show);
        }
        return allShows;
    }

    private static void Header(string text)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"\n{text.ToUpper()}\n");
        Console.ForegroundColor = ConsoleColor.White;
    }

    private static void WriteInfoAboutShow(Show show)
    {
        Console.WriteLine($"{show.Channel.PadRight(4)} {show.StartAt} {show.Title}");
    }

}
