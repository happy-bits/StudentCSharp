// Syfte: ett exception kan skickas djupt nere i programkoden och "bubbla" upp till en högre nivå där det fångas

namespace CSharpCourse.Exceptions.Demo;

public class Demo2
{
    public static void Run()
    {

        try
        {
            double height = AskForNumber("Ange höjd: ");
            double width = AskForNumber("Ange bredd: ");

            double result = TriangleArea(height, width);

            Console.WriteLine($"Arean av triangeln är {result}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Du måste ange en siffra");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }

    }

    private static double AskForNumber(string text)
    {
        Console.Write(text);
        double answer = double.Parse(Console.ReadLine()!);
        return answer;
    }

    private static double TriangleArea(double height, double width)
    {
        if (width <0 && height <0)
            throw new ArgumentException("Både höjden och bredden är negativ!");

        if (height<0)
            throw new ArgumentException("Höjden får inte vara negativ!");

        if (width < 0)
            throw new ArgumentException("Bredden får inte vara negativ!");

        return height * width / 2;
    }
}
