namespace Interview.Services.DifferentExamples;

public class MethodsWithSimilarSignature
{
    public static void Method2(params int[] a)
    {
        Console.WriteLine(1);
    }

    public static void Method2(int a, int b)
    {
        Console.WriteLine(2);
    }

    public static void Method2(int a, params int[] b)
    {
        Console.WriteLine(3);
    }
}