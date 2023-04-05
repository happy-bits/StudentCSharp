// Syfte: enklast möjliga sätt att krascha programmet

namespace CSharpCourse.Exceptions.Demo;

public class Demo0
{
    public static void Run()
    {
        Console.WriteLine("Snart lunch");

        throw new Exception("Ojojoj!");
    }
}
