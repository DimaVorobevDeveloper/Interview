namespace Interview.Services.SynchronizationPrimitives;

public class DeadlockCaseTwo
{
    static AutoResetEvent waitHandler = new AutoResetEvent(true);

    public static void Main()
    {
        Console.WriteLine("Deadlock demo. Please check where threads are stuck.");

        for (int i = 0; i < 3; i++)
        {
            waitHandler.WaitOne();
            if (i == 1)
            {
                continue;
            }
            waitHandler.Set();
        }

        Console.WriteLine("This will not be in output");

        Console.ReadLine();
    }
}