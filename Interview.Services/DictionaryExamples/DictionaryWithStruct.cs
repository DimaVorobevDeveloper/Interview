namespace Interview.Services.DictionaryExamples;

public class DictionaryWithStruct
{
    public static void Main()
    {
        var dictionary = new Dictionary<MyStruct, string>();
        var str = new MyStruct
        {
            Value = 1
        };
        var str2 = new MyStruct
        {
            Value = 2
        };
        dictionary[str] = "record 1";
        dictionary[str2] = "record 2";
        str.Value = 3;
        dictionary[str] = "record 3";

        foreach (var pair in dictionary)
        {
            Console.WriteLine($"{pair.Key} {pair.Value}");
        }
    }
}


public struct MyStruct
{
    public int Value { get; set; }

    public override int GetHashCode()
    {
        return 0;
    }
}