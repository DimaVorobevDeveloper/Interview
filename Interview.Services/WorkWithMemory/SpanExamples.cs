namespace Interview.Services.WorkWithMemory;

public class SpanExamples
{
    public const int N = 1000;
    public const int Min = -99;
    public const int Max = 99;

    public static Span<int> GetNumsSpanV1(int[] nums)
    {
        Random randNum = new Random();
        var numsNew = Enumerable
            .Repeat(0, N)
            .Select(i => randNum.Next(Min, Max))
            .ToArray();

        numsNew.Union(nums);
        var numsSpan = new Span<int>(numsNew);
        return numsSpan;
    }

    public static Span<int> GetNumsSpanV2(int[] people)
    {
        Span<int> numsSpan = people;
        return numsSpan;
    }

    public static Span<string> GetPeopleV1(string[] people)
    {
        Random randNum = new Random();
        var peopleNew = Enumerable
            .Repeat(0, N)
            .Select(i => $"people{randNum.Next(Min, Max)}")
            .ToArray();

        peopleNew.Union(people);
        var peopleSpan = new Span<string>(peopleNew);
        return peopleSpan;
    }

    public static Span<string> GetPeopleV2(string[] people)
    {
        Span<string> peopleSpan = people;
        return peopleSpan;
    }

    public static string[] GetPeopleArrayWithoutSpan(string[] people)
    {
        var peopleSpan = people;
        return peopleSpan;
    }
}