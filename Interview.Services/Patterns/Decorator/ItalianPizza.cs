namespace Interview.Services.Patterns.Decorator;

public class ItalianPizza : Pizza
{
    /// <summary>
    /// итальянская пицца с томатами
    /// </summary>
    public ItalianPizza() : base("Итальянская пицца")
    { }

    public override int GetCost()
    {
        return 10;
    }
}