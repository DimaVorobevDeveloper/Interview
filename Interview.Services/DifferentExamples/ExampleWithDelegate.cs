namespace Interview.Services.DifferentExamples;

public class ExampleWithDelegate
{
    public delegate int A(string b);

    public int InitializationOfDelegates(string b)
    {
        Delegate a = delegate () { return 1; };
        object a1 = delegate () { return 1; };
        Console.WriteLine("Message");

        return a1.GetHashCode();
    }

    public static void ActionSubscribe(string b)
    {
        Action a = () => { };
        a += () => Console.WriteLine("123");
        a -= () => Console.WriteLine("123");
        a();
    }
}