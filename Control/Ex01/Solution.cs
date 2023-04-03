namespace CSharpCourse.Control.Ex01;

public class Solution
{
    public static void DoYouNeedToSleep()
    {
        // 21 6      (24-21) + 6             6 - 21 + 24
        // 22 6      (24-22) + 6             6 - 22 + 24
        // 23 6      (24-23) + 6             6 - 23 + 24
        // 0  6      6 - 0                   6 - 0 
        // 1  6      6 - 1                   6 - 1

        Console.Write("When did you go to bed yesterday? ");
        int toSleep = int.Parse(Console.ReadLine()!);

        Console.Write("When did you wake up? ");
        int wokeUp = int.Parse(Console.ReadLine()!);

        int sleepTime;

        if (toSleep > wokeUp)
            sleepTime = wokeUp + (24 - toSleep);
        else
            sleepTime = wokeUp - toSleep;

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine();

        if (sleepTime < 6)
            Console.WriteLine($"You've only slept {sleepTime}. Go back to bed!");
        else if (sleepTime > 12)
            Console.WriteLine($"You've slept {sleepTime} hours. That's a lot.");
        else
            Console.WriteLine($"You have slept well. ({sleepTime} hours)");

        // Alternative with switch-when:

        //switch (sleepTime)
        //{
        //    case int n when n < 6:
        //        Console.WriteLine($"You've only slept {sleepTime}. Go back to bed!");
        //        break;
        //    case int n when n > 12:
        //        Console.WriteLine($"You've slept {sleepTime} hours. That's a lot."); 
        //        break;
        //    default:
        //        Console.WriteLine($"You have slept well. ({sleepTime} hours)");
        //        break;
        //}

    }

    // Solution 1 Alternative

    public static void DoYouNeedToSleep_WithTimespan()
    {
        Console.Write("When did you go to bed yesterday? ");
        TimeSpan toSleep = TimeSpan.Parse(Console.ReadLine()!);

        Console.Write("When did you wake up? ");
        TimeSpan wokeUp = TimeSpan.Parse(Console.ReadLine()!);

        if (toSleep > wokeUp)
            wokeUp = wokeUp.Add(TimeSpan.FromDays(1));

        double sleepTime = (wokeUp - toSleep).TotalHours;

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine();

        if (sleepTime < 6)
        {
            Console.WriteLine($"You've only slept {sleepTime}. Go back to bed!");
        }
        else if (sleepTime > 12)
        {
            Console.WriteLine($"You've slept {sleepTime} hours. That's a lot.");
        }
        else
        {
            Console.WriteLine($"You have slept well. ({sleepTime} hours)");
        }
    }
}
