using System.Text;
using BenchmarkDotNet.Attributes;

namespace Interview.Services.BenchmarkTests;

[MemoryDiagnoser]
public class SbBenchmark
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
    public SbBenchmark()
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
    public void AppendOnes1() => AppendOnes();

    [Benchmark]
    public void AppendManyTimes1() => AppendManyTimes();


    private void AppendOnes()
    {
        var sb = new StringBuilder();
        var c1 = 1;
        var c2 = 2;
        sb.Append($"saleEvent.SmartCardType.TypeName.ToUpper() - {c1} шт. СУММА {c2}, ");
    }

    private void AppendManyTimes()
    {
        var sb = new StringBuilder();
        var c1 = 1;
        var c2 = 2;
        sb.Append("saleEvent.SmartCardType.TypeName.ToUpper()");
        sb.Append(" – ");
        sb.Append(c1);
        sb.Append(" шт.");
        sb.Append("СУММА: ");
        sb.Append(c2);
        sb.Append(", ");
    }
}

