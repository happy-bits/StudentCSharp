namespace CSharpCourse.Fundamentals.Ex02;

public class Solution
{
    public static void WhatsYourName_WithTypes()
    {
        Console.Write("What is your name? ");
        string name = Console.ReadLine()!;

        Console.Write("How old are you? ");
        int age = int.Parse(Console.ReadLine()!);

        Console.Write("What is your favorite character? ");
        char character = char.Parse(Console.ReadLine()!);

        Console.WriteLine();
        Console.WriteLine("Thank you!");
        Console.WriteLine();

        Console.ForegroundColor = ConsoleColor.Green;

        int untilRetirement = 65 - age;
        bool userLikesNumbers = char.IsNumber(character);

        Console.WriteLine("Your name is: " + name);
        Console.WriteLine("You have " + untilRetirement + " years until retirement");

        if (userLikesNumbers)
            Console.WriteLine("Your like numbers");
        else
            Console.WriteLine("Your don't like numbers");

        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine();
    }
}
