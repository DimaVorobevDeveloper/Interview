namespace Interview.Services.DictionaryExamples;

public class DictionaryWithClass
{
    public static void Main()
    {
        var dictionary = new Dictionary<MyClass, string>();
        var str = new MyClass
        {
            Value = 1
        };
        var str2 = new MyClass
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

        Console.ReadKey();
    }
}

public class MyClass
{
    public int Value { get; set; }

    public override int GetHashCode()
    {
        return 0;
    }
}