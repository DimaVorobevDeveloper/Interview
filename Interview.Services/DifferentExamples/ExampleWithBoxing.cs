namespace Interview.Services.DifferentExamples;

public class ExampleWithBoxing
{
    public static void StructBoxing(string b)
    {
        MyStruct a = new MyStruct();
        a.i = 5;

        Object obj = (object)a;
        var str = (MyStruct)obj;
        str.i = 1_0;
        Console.WriteLine(((MyStruct)obj).i);
    }
}

struct MyStruct
{
    public int i;
}