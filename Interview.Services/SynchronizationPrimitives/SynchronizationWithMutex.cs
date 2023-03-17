﻿namespace Interview.Services.SynchronizationPrimitives;

public class SynchronizationWithMutex
{
    static Mutex mutexObj = new Mutex();
    static int x = 0;

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
        mutexObj.WaitOne();
        x = 1;
        for (int i = 1; i < 6; i++)
        {
            Console.WriteLine($"{Thread.CurrentThread.Name}: {x}");
            x++;
            Thread.Sleep(100);
        }
        mutexObj.ReleaseMutex();
    }
}