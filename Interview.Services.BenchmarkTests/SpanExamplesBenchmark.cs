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
    /// |                    Method |           Mean |         Error |        StdDev |         Median |    Gen0 | Allocated |
    /// |-------------------------- |---------------:|--------------:|--------------:|---------------:|--------:|----------:|
    /// |             GetNumsSpanV1 | 13,191.4929 ns |   263.7708 ns |   676.1453 ns | 12,927.7046 ns |  1.0376 |    4344 B |
    /// |             GetNumsSpanV2 |      0.2307 ns |     0.0362 ns |     0.0471 ns |      0.2120 ns |       - |         - |
    /// |               GetPeopleV1 | 73,658.0978 ns | 1,343.1433 ns | 2,091.1123 ns | 73,029.3213 ns | 11.4746 |   48344 B |
    /// |               GetPeopleV2 |      0.3807 ns |     0.0329 ns |     0.0307 ns |      0.3659 ns |       - |         - |
    /// | GetPeopleArrayWithoutSpan |      0.3400 ns |     0.0137 ns |     0.0121 ns |      0.3387 ns |       - |         - |
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
    public Span<int> GetNumsSpanV2() => SpanExamples.GetNumsSpanV2(nums);

    [Benchmark]
    public Span<string> GetPeopleV1() => SpanExamples.GetPeopleV1(people);

    [Benchmark]
    public Span<string> GetPeopleV2() => SpanExamples.GetPeopleV2(people);

    [Benchmark]
    public Span<string> GetPeopleArrayWithoutSpan() => SpanExamples.GetPeopleArrayWithoutSpan(people);
}
