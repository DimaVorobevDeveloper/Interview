namespace Interview.Services.SynchronizationPrimitives;

public class SynchronizationWithLock
{
    static int x = 0;
    static object locker = new object();
    public static void Main()
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
        lock (locker)
        {
            x = 1;
            for (int i = 1; i < 6; i++)
            {
                Console.WriteLine($"{Thread.CurrentThread.Name}: {x}");
                x++;
                Thread.Sleep(100);
            }
        }
    }
}