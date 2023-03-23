namespace Interview.Services.DifferentExamples;

public class ExampleWithBoxing
{
    public static int StructBoxing(int input = 5)
    {
        MyStruct a = new MyStruct();
        a.Count = input;

        Object obj = (object)a;
        
        var str = (MyStruct)obj;
        str.Count = 1_0;

        var result = ((MyStruct) obj).Count;
        Console.WriteLine(result);
        return result;
    }
}

struct MyStruct
{
    public int Count;
}