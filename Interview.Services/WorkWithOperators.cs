namespace Interview.Services;

public class WorkWithOperators
{
    public static void Do()
    {
        int i = 5;

        var t = i += 1;
        Console.WriteLine(i += 1);
        Console.WriteLine(++i);
        Console.WriteLine(i++);
        Console.WriteLine(i);
    }
}

class WorkWithOperators1
{
}