namespace Interview.Services.SynchronizationPrimitives;

public class SynchronizationWithMonitor
{
    static int x = 0;
    static object locker = new object();
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
        bool acquiredLock = false;
        try
        {
            Monitor.Enter(locker, ref acquiredLock);
            x = 1;
            for (int i = 1; i < 6; i++)
            {
                Console.WriteLine($"{Thread.CurrentThread.Name}: {x}");
                x++;
                Thread.Sleep(100);
            }
        }
        finally
        {
            if (acquiredLock) Monitor.Exit(locker);
        }
    }
}