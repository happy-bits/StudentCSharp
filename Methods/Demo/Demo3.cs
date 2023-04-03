// Added validation so you can't enter to early times

namespace CSharpCourse.Methods.Demo;

public class Demo3
{
    public static void Run()
    {
        TimeSpan start = AskForTime("When did you start working in the morning?", TimeSpan.Zero);
        TimeSpan lunch = AskForTime("When did you go for lunch?", start);
        TimeSpan lunchEnd = AskForTime("When did your lunch end?", lunch);
        TimeSpan end = AskForTime("When did you go home from work?", lunchEnd);

        TimeSpan worktime = CalculateWorkTime(start, lunch, lunchEnd, end);

        Console.WriteLine();
        Console.WriteLine($"You have worked {worktime.Hours}h and {worktime.Minutes} minutes");

    }

    private static TimeSpan CalculateWorkTime(TimeSpan start, TimeSpan lunch, TimeSpan lunchEnd, TimeSpan end)
    {
        return lunch - start + end - lunchEnd;
    }

    private static TimeSpan AskForTime(string question, TimeSpan mustBeLaterThan)
    {
        while (true)
        {
            Console.Write(question + " ");
            string answer = Console.ReadLine()!;
            TimeSpan time;
            bool success = TimeSpan.TryParse(answer, out time);

            if (success)
            {
                if (time.Days == 0 && time > mustBeLaterThan)
                    return time;
            }
        }
    }
}
