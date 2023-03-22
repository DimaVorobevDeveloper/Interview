using System.Buffers;

namespace Interview.Services.WorkWithMemory;

public class SpanExamples
{
    public const int N = 10000;
    public const int Min = -99;
    public const int Max = 99;

    public static Span<int> GetNumsSpanV1(int[] nums)
    {
        //var share1d = MemoryPool<int>.Shared;
            //var shared = ArrayPool<int>.Create(4, 10);
        var shared = ArrayPool<int>.Shared;
        var rentedArray = shared.Rent(N);

        Random randNum = new Random();
        rentedArray = Enumerable
            .Repeat(0, randNum.Next(0, N))
            .Select(i => randNum.Next(Min, Max))
            .ToArray();

        rentedArray.Union(nums);
        var numsSpan = new Span<int>(rentedArray);
        // shared.Return(rentedArray);
        return numsSpan;
    }

    public static Span<int> GetNumsSpanV2(int[] nums)
    {
        Random randNum = new Random();

        var numsNew = Enumerable
            .Repeat(0, randNum.Next(0, N))
            .Select(i => randNum.Next(Min, Max))
            .ToArray();

        numsNew.Union(nums);
        var numsSpan = new Span<int>(numsNew);
        return numsSpan;
    }

    public static Span<int> GetNumsSpanV3(int[] nums)
    {
        var memoryPool = MemoryPool<int>.Shared;
        var arrayPool = ArrayPool<int>.Create(N, N);
        var rentedArray = arrayPool.Rent(N);
        for (int i = 0; i < N; i++)
        {
            rentedArray[i] = i + 1;
        }
        for (int j = 0; j < N; j++)
        {
            // Console.WriteLine(rentedArray[j]);
        }
        arrayPool.Return(rentedArray);

        var numsSpan = new Span<int>(rentedArray);
        return numsSpan;
    }

    public static Span<string> GetPeopleV1(string[] people)
    {
        Random randNum = new Random();
        var peopleNew = Enumerable
            .Repeat(0, randNum.Next(0, N))
            .Select(i => $"people{randNum.Next(Min, Max)}")
            .ToArray();

        peopleNew.Union(people);
        var peopleSpan = new Span<string>(peopleNew);
        return peopleSpan;
    }

    public static Span<string> GetPeopleV2(string[] people)
    {
        var shared = ArrayPool<string>.Shared;
        var rentedArray = shared.Rent(N);

        Random randNum = new Random();
        rentedArray = Enumerable
            .Repeat(0, randNum.Next(0, N))
            .Select(i => $"people{randNum.Next(Min, Max)}")
            .ToArray();

        rentedArray.Union(people);
        var peopleSpan = new Span<string>(rentedArray);
        shared.Return(rentedArray);
        return peopleSpan;
    }

    public static string[] GetPeopleArrayWithoutSpan(string[] people)
    {
        var peopleSpan = people;
        return peopleSpan;
    }
}