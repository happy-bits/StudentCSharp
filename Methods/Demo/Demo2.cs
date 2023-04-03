/*
 
  Better with "AskForTime". Less repetition

  We can remove the comments when we create more methods, like ReportWorkingHours

 */

namespace CSharpCourse.Methods.Demo;

public class Demo2
{
    public static void Run()
    {
        TimeSpan start = AskForTime("When did you start working in the morning?");
        TimeSpan lunch = AskForTime("When did you go for lunch?");
        TimeSpan lunchEnd = AskForTime("When did your lunch end?");
        TimeSpan end = AskForTime("When did you go home from work?");

        ReportWorkingHours(start, lunch, lunchEnd, end);
    }

    private static void ReportWorkingHours(TimeSpan start, TimeSpan lunch, TimeSpan lunchEnd, TimeSpan end)
    {
        TimeSpan worktime = lunch - start + end - lunchEnd;
        Console.WriteLine();

        Console.WriteLine($"You have worked {worktime.Hours}h and {worktime.Minutes} minutes");
    }

    private static TimeSpan AskForTime(string question)
    {
        Console.Write(question + " ");
        string answer = Console.ReadLine()!;
        TimeSpan time = TimeSpan.Parse(answer);
        return time;
    }
}
