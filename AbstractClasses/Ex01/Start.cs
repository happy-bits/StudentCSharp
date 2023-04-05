namespace CSharpCourse.AbstractClasses.Ex01;

public class Start
{
    public static void Run()
    {
        //var t0 = new FileTransformer(); // Kan inte skapa instans av abstrakt klass

        var t1 = new UpperCaseFileTransformer();
        t1.TransformFile(@"AbstractClasses\Ex01\sample1.txt");

        var t2 = new RemoveStarsFileTransformer();
        t2.TransformFile(@"AbstractClasses\Ex01\sample2.txt");

    }
}
