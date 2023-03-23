namespace Interview.Services.DifferentExamples;

public class ExampleWithTryFinally
{
    public static int GetValue(int a = 100)
    {
        try
        {
            return a;
        }
        finally
        {
            a = 1234;
        }
    }

    // будет ли ошибка
    public static void GetValue()
    {
        // try
        // {
        //     string str = null;
        //     Console.WriteLine(str.Length);
        // }
        // catch (Exception e)
        // {
        //     Console.WriteLine("str = " + str);
        // }
    }
}