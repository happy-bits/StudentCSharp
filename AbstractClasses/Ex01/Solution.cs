namespace CSharpCourse.AbstractClasses.Ex01;

public class Solution
{
    public static void Run()
    {
        //var t0 = new FileTransformer(); // Kan inte skapa instans av abstrakt klass

        string dataFolder = @"C:\Project\CSharpCourse\CSharpCourse\AbstractClasses\Ex01\data\";

        var t1 = new UpperCaseFileTransformer();
        t1.TransformFile(Path.Combine(dataFolder, "sample1.txt"));

        var t2 = new RemoveStarsFileTransformer();
        t2.TransformFile(Path.Combine(dataFolder, "sample2.txt"));

        var t3 = new ChangeSwedishLettersFileTransformer();
        t3.TransformFile(Path.Combine(dataFolder, "sample3.txt"));
    }
}
