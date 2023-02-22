namespace Interview.Services.Patterns.Mediator;

public abstract class Mediator
{
    public abstract void Send(string msg, Colleague colleague);
}


// класс заказчика
// класс программиста
// класс тестера