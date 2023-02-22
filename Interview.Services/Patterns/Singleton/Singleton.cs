namespace Interview.Services.Patterns.Singleton;

/// <summary>
/// Одиночка (Singleton, Синглтон) - порождающий паттерн, который гарантирует,
/// что для определенного класса будет создан только один объект,
/// а также предоставит к этому объекту точку доступа.
/// </summary>
public class Singleton
{
    private static Singleton instance;

    private Singleton()
    { }

    public static Singleton getInstance()
    {
        return instance ??= new();
    }

    public void Log()
    {
        Console.WriteLine("Log some text");
    }
}

