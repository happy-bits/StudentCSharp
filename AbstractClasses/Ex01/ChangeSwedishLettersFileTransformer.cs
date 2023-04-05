namespace CSharpCourse.AbstractClasses.Ex01;

class ChangeSwedishLettersFileTransformer : FileTransformer
{
    protected override string Transform(string content)
    {
        return content
            .Replace("å", "a")
            .Replace("Å", "A")
            .Replace("ä", "a")
            .Replace("Ä", "A")
            .Replace("ö", "o")
            .Replace("Ö", "O");
    }
}
