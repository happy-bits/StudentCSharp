using ConsoleUtilities;

namespace CSharpCourse.Exceptions.Ex01;

public class Solution
{
    public static void ChocolateTest1()
    {
        ConsoleCompanion cc = new ConsoleCompanion();
        Console.WriteLine("The chocolate contains 24 pieces");
        int people = cc.AskForInteger("How many want to share?");
        decimal piecePerPerson = 24M / people; // Has to have M to avoid int division

        // Alternative: 
        // decimal piecePerPerson = decimal.Divide(24, people);

        // Doesn't work, gives Infinity as answer (not exception):
        //double piecePerPerson = 24.0 / people; // Has to have .0 to avoid int division

        Console.WriteLine($"Everyone get {piecePerPerson:.##} pieces");
    }

    public static void ChocolateTest2()
    {
        ConsoleCompanion cc = new ConsoleCompanion();
        Console.WriteLine("The chocolate contains 10 pieces");
        int people = cc.AskForInteger("How many want to share?");

        try
        {
            decimal piecePerPerson = 10M / people;
            Console.WriteLine($"Everyone get {piecePerPerson:.##} pieces");
        }
        catch (DivideByZeroException)
        {
            cc.WriteLineRed("Zero people can't divide a chocolate");
        }
        catch (Exception)
        {
            cc.WriteLineRed("Something strange happened!");
        }

    }
}
