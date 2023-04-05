namespace CSharpCourse.AbstractClasses.Ex01;

abstract class FileTransformer
{
    private readonly string _outputSuffix = "-transformed.txt";

    public void TransformFile(string filename)
    {
        string newFilename = filename + _outputSuffix;
        try
        {
            string content = File.ReadAllText(filename);

            string transformed = Transform(content);

            File.WriteAllText(newFilename, transformed);
        }
        catch(Exception ex)
        {
            Console.WriteLine($"Unexpected error when transforming file {newFilename}");
            Console.WriteLine();
            Console.WriteLine($"Details: {ex.Message}");
            return;
        }
        Console.WriteLine($"Transformed {newFilename} successfully!");
    }

    protected abstract string Transform(string content);

}
