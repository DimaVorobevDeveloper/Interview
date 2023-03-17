using BenchmarkDotNet.Attributes;
using Interview.Services.DictionaryExamples;

namespace Interview.Services.BenchmarkTests;

[MemoryDiagnoser]
public class DictionaryWithBenchmark
{
    private const int N = 30;
    private readonly int[] nums;
    private readonly int target;

    /// <summary>
    /// |                     Method |        Mean |     Error |     StdDev |     Gen0 | Allocated |
    /// |--------------------------- |------------:|----------:|-----------:|---------:|----------:|
    /// |                   ThreeSum |    68.51 us |  1.176 us |   2.028 us |   0.7324 |   3.38 KB |
    /// | ThreeSumWithoutOptimizeWay | 3,363.42 us | 66.145 us | 108.678 us | 222.6563 |  913.6 KB |
    /// </summary>
    public DictionaryWithBenchmark()
    {
        //int min = -990;
        //int max = 990;
        //Random randNum = new Random();
        //nums = Enumerable
        //    .Repeat(0, N)
        //    .Select(i => randNum.Next(min, max))
        //    .ToArray();

        //target = randNum.Next(min, max);
    }

    [Benchmark]
    public void DictionaryWithClassMethod() => DictionaryWithClass.Main();

    [Benchmark]
    public void DictionaryWithStructMethod() => DictionaryWithStruct.Main();
}