namespace Interview.Services.Patterns.Strategy;

public class Context
{
    public IStrategy ContextStrategy { get; set; }

    public Context(IStrategy strategy)
    {
        ContextStrategy = strategy;
    }

    public void ExecuteAlgorithm()
    {
        ContextStrategy.Algorithm();
    }
}