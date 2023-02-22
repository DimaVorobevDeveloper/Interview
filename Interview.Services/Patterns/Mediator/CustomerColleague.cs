namespace Interview.Services.Patterns.Mediator;

public class CustomerColleague : Colleague
{
    public CustomerColleague(Mediator mediator)
        : base(mediator)
    { }

    public override void Notify(string message)
    {
        Console.WriteLine("Сообщение заказчику: " + message);
    }
}