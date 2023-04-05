// Syfte: visa hur man kan fånga olika typer av exceptions

namespace CSharpCourse.Exceptions.Demo;

public class Demo1
{
    public static void Run()
    {
        Console.Write("Ange en siffra: ");

        try
        {
            decimal number = decimal.Parse(Console.ReadLine()!);

            decimal division = 1 / number;
            Console.WriteLine($"Ett delat med talet blir {division}");
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Division med 0");
        }
        catch (FormatException)
        {
            Console.WriteLine("Fel i formatet");
        }
        catch (OverflowException)
        {
            Console.WriteLine("För stort eller för litet tal");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Något annat gick snett");
            Console.WriteLine(ex.Message);
            Console.WriteLine(ex.StackTrace);

        }

    }
}
