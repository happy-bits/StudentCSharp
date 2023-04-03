namespace CSharpCourse.Fundamentals.Ex01;

public class Solution
{
    // Solution 1 

    public static void WhatsYourName()
    {
        Console.Write("What is your name? ");
        string name = Console.ReadLine()!;

        Console.Write("How old are you? ");
        string age = Console.ReadLine()!;

        Console.Write("What is your favorite letter? ");
        string letter = Console.ReadLine()!;

        Console.WriteLine();
        Console.WriteLine("Thank you!");
        Console.WriteLine();

        Console.ForegroundColor = ConsoleColor.Green;

        Console.WriteLine("Your name is: " + name);
        Console.WriteLine("You are " + age + " years old");
        Console.WriteLine("Your favorite letter is " + letter);

        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine();
    }
}
