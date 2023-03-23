namespace Interview.Services.DifferentExamples;

public class WithConstructor
{
    public void Wi()
    {
        SomeClass a = new SomeClass(1) { Value = 2 };
        Console.WriteLine(a.Value);
    }
}

class SomeClass
{
    public int Value;

    public SomeClass(int value)
    {
        this.Value = value;
    }
}