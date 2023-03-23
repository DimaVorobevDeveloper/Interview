namespace Interview.Services.DifferentExamples;

public class ExampleWithOutRef
{
    public static (int result1, int result2, int result3) RunAllExamples(int i = 0)
    {
        SetupToValueWithoutRef(i);
        Console.WriteLine(i);
        var result1 = i;

        i = 0;
        SetupRefValue(ref i);
        Console.WriteLine(i);
        var result2 = i;

        i = 0;
        SetupOutValue(out i);
        Console.WriteLine(i);
        var result3 = i;

        return (result1, result2, result3);
    }

    static void SetupToValueWithoutRef(int i)
    {
        i = 111;
    }

    static void SetupRefValue(ref int i)
    {
        i = 222;
    }

    static void SetupOutValue(out int i)
    {
        i = 333;
    }

    static (int a, int b) SwapExample(int a = 1, int b = 2)
    {
        Swap(a, b);
        Console.WriteLine("a = {0}, b = {1}", a, b);
        return (a, b);
    }

    static void Swap(int a, int b)
    {
        (a, b) = (b, a);
    }
}