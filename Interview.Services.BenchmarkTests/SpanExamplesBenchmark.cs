using BenchmarkDotNet.Attributes;
using Interview.Services.WorkWithMemory;

namespace Interview.Services.BenchmarkTests;

[MemoryDiagnoser]
public class SpanExamplesBenchmark
{
    private const int N = 3000;
    private readonly int[] nums;
    private readonly string[] people;

    /// <summary>
    /// |        Method |      Mean |    Error |   StdDev |    Gen0 |    Gen1 | Allocated |
    /// |-------------- |----------:|---------:|---------:|--------:|--------:|----------:|
    /// | GetNumsSpanV1 |        NA |       NA |       NA |       - |       - |         - |
    /// | GetNumsSpanV2 |  63.59 us | 1.046 us | 1.119 us |  4.7607 |       - |   20287 B |
    /// |   GetPeopleV1 | 391.40 us | 6.116 us | 5.721 us | 41.0156 | 18.5547 |  234063 B |
    /// |   GetPeopleV2 |        NA |       NA |       NA |       - |       - |         - |
    /// </summary>
    public SpanExamplesBenchmark()
    {
        int Min = -99;
        int Max = 99;
        Random randNum = new Random();
        nums = Enumerable
            .Repeat(0, N)
            .Select(i => randNum.Next(Min, Max))
            .ToArray();

        people = Enumerable
            .Repeat(0, N)
            .Select(i => $"people{randNum.Next(Min, Max)}")
            .ToArray();
    }

    [Benchmark]
    public Span<int> GetNumsSpanV1() => SpanExamples.GetNumsSpanV1(nums);

    [Benchmark]
    public Span<int> GetNumsSpanV2() => SpanExamples.GetNumsSpanV3(nums);

    //[Benchmark]
    //public Span<string> GetPeopleV1() => SpanExamples.GetPeopleV1(people);

    //[Benchmark]
    //public Span<string> GetPeopleV2() => SpanExamples.GetPeopleV2(people);

    //[Benchmark]
    //public Span<string> GetPeopleArrayWithoutSpan() => SpanExamples.GetPeopleArrayWithoutSpan(people);
}
