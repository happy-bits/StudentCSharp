/* 
   
   Visar hur man kan lösa vissa uppgifter lättare med LINQ:
   - Ta medelvärde
   - Summera
   - Filtrera en lista
   - Manipulera en lista

 */

namespace CSharpCourse.Linq.Demo;

public class Demo1
{
    public static void Run()
    {
        var list = new List<int> { 3, 10, 7 };

        Header("Listan:");
        //Console.WriteLine($"list = {string.Join(",", list)}");
        Display("list", list);

        Header("Utan linq:");

        // These functions don't use LINQ

        double avg = Average(list); // Aggregering
        double sum = Sum(list);
        double avg2 = AverageShorter(list); // Aggregering

        IEnumerable<int> numberHigherThanFive = NumberHigherThanFive(list); // Filtering
        IEnumerable<string> starslist = StarifyList(list);                  // Manipulation 

        Display("average", avg);
        Display("average shorter", avg2);
        Display("sum", sum);
        Display("numberHigherThanFive", numberHigherThanFive);
        Display("starslist", starslist);

        //Console.WriteLine($"average = {avg}");
        //Console.WriteLine($"sum = {sum}");
        //Console.WriteLine($"numberHigherThanFive = {string.Join(",", numberHigherThanFive)}");
        //Console.WriteLine($"starslist = {string.Join(",", starslist)}");

        // Using LINQ

        Header("Med linq:");

        //IEnumerable<int> numbersHigherThanFiveLinq = list.Where(Kalle);
        IEnumerable<int> numberHigherThanFiveLinq = list.Where(i => i > 5);
        IEnumerable<string> starslistLinq = list.Select(x => $"*{x}*");

        Display("average", list.Average());
        Display("sum", list.Sum());
        Display("numberHigherThanFiveLinq", numberHigherThanFiveLinq);
        Display("starslistLinq", starslistLinq);

        // Chaining LINQ expressions

        Header("Bonus:");
        IEnumerable<string> bonus = list.Where(i => i > 5).Select(i => $"*{i}*");
        Display("bonus", bonus);

        IEnumerable<string> bonus2 = list.Where(i => i > 5).OrderBy(i=>i).Select(i => $"*{i}*");
        Display("bonus2", bonus2);

        Console.WriteLine();
        Console.ReadKey();
    }

    private bool IsHighNumber(int i)
    {
        if (i > 5)
            return true;
        else
            return false;
    }

    private bool IsHighNumber_Shorter(int i)
    {
        return i > 5;
    }

    private bool IsHighNumber_Even_Shorter(int i) => i > 5;

    private static void Display(string text, IEnumerable<int> list)
    {
        Display(text, string.Join(",", list));
    }

    private static void Display(string text, IEnumerable<string> list)
    {
        Display(text, string.Join(",", list));
    }

    private static void Display(string text, object o)
    {
        Console.WriteLine($"{text} = {o}");
    }

    private static IEnumerable<int> NumberHigherThanFive(IEnumerable<int> list)
    {
        var result = new List<int>();
        foreach (var i in list)
        {
            if (i > 5)
                result.Add(i);
        }
        return result;
    }

    private static double Average(IEnumerable<int> list)
    {
        double sum = 0;
        foreach (var i in list)
        {
            sum += i;
        }
        return sum / list.Count(); 
    }

    private static double AverageShorter(IEnumerable<int> list)
    {
        double sum = 0;
        foreach (int i in list)
        {
            sum += i;
        }
        return sum / list.Count();
    }

    private double Average_Alternative(IEnumerable<int> list)
    {
        return Sum(list) / list.Count();
    }

    private static double Sum(IEnumerable<int> list)
    {
        double sum = 0;
        foreach (int i in list)
        {
            sum += i;
        }
        return sum;
    }

    private static IEnumerable<string> StarifyList(IEnumerable<int> list)
    {
        var result = new List<string>();
        foreach (int i in list)
        {
            result.Add($"*{i}*");
        }
        return result;
    }

    private static void Header(string message)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine();
        Console.WriteLine(message.ToUpper());
        Console.WriteLine();
    }
}
