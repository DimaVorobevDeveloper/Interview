namespace Interview.Services.DifferentExamples;

public class ExampleWithUnaryOperators
{
    public static int MultipleIncrement(int i = 0)
    {
        Console.WriteLine("{0}", i++); // 0
        Console.WriteLine("{0}", i++); // 1
        Console.WriteLine("{0}", i++); // 2
        Console.WriteLine("{0}", i++); // 3
        i += i++ + i++; // 4 + 4
        Console.WriteLine("{0}", i); // 1,2

        return i;
    }

    public static int SingleIncrement(int i = 0)
    {
        Console.WriteLine("{0}", ++i); // 1
        Console.WriteLine("{0}", i); // 1
        return i;
    }

    public static (int result1, int result2, int result3) ApplyMultiOperators()
    {
        int i = 7;
        var result1 = i += 100000 == 0 ? 22 : 55;
        Console.WriteLine(result1);

        int j = 1;
        var result2 = j += 0 == 0 ? 2 : 3;
        Console.WriteLine();
        Console.WriteLine(result2);

        int k = 1;
        var result3 = k += 1 == 0 ? 2 : 3;
        Console.WriteLine();
        Console.WriteLine(result3);

        Console.WriteLine($"{i} -> {result1}, {j} -> {result2}, {k} -> {result3}");

        return (result1, result2, result3);
    }

    public static int ConvertBoolToIntIfNull()
    {
        int? i = null;
        var result = i ?? Convert.ToInt32(i.HasValue);
        Console.WriteLine(result);
        return result;
    }
}