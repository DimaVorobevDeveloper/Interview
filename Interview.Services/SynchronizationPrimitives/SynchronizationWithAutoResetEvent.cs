namespace Interview.Services.SynchronizationPrimitives;

public class SynchronizationWithAutoResetEvent
{
    static AutoResetEvent waitHandler = new AutoResetEvent(true);
    static int x = 0;

    public static void Main(string[] args)
    {
        for (int i = 1; i < 6; i++)
        {
            Thread myThread = new Thread(Count);
            myThread.Name = $"Thread {i}";
            myThread.Start();
        }

        Console.ReadLine();
    }
    public static void Count()
    {
        waitHandler.WaitOne();
        x = 1;
        for (int i = 1; i < 6; i++)
        {
            Console.WriteLine($"{Thread.CurrentThread.Name}: {x}");
            x++;
            Thread.Sleep(100);
        }
        waitHandler.Set();
    }
}