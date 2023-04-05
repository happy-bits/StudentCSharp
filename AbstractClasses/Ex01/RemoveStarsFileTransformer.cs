namespace CSharpCourse.AbstractClasses.Ex01;

class RemoveStarsFileTransformer : FileTransformer
{
    protected override string Transform(string content)
    {
        return content.Replace("*", "");
    }
}
