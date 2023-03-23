namespace Interview.Services.DifferentExamples;

internal class GetNotInitValue
{
    static int one = GetAnother();
    // исправить так static int a => GetAnother();
    static int another = 5;

    static int GetAnother()
    {
        return another;
    }
}