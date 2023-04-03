// Another example with geometry

namespace CSharpCourse.Methods.Demo;

public class Demo4
{
    public static void Run()
    {
        Console.Write("Enter height of triangle1: ");
        double triangle1Height = double.Parse(Console.ReadLine()!);

        Console.Write("Enter width of triangle1: ");
        double triangle1Width = double.Parse(Console.ReadLine()!);

        Console.Write("Enter height of triangle2: ");
        double triangle2Height = double.Parse(Console.ReadLine()!);

        Console.Write("Enter width of triangle2: ");
        double triangle2Width = double.Parse(Console.ReadLine()!);

        double area1 = triangle1Height * triangle1Width / 2;
        double area2 = triangle2Height * triangle2Width / 2;

        Console.WriteLine("Area of triangle1 is: " + area1);
        Console.WriteLine("Area of triangle2 is: " + area2);

    }
}
