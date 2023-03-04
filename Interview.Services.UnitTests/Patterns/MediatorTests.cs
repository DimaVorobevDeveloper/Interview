using Interview.Services.Patterns.Mediator;

namespace Interview.Services.UnitTests.Patterns;

[TestClass]
public class MediatorTests
{
    [TestMethod]
    public void Do()
    {
        ManagerMediator mediator = new ManagerMediator();
        Colleague customer = new CustomerColleague(mediator);
        Colleague programmer = new ProgrammerColleague(mediator);
        Colleague tester = new TesterColleague(mediator);
        mediator.Customer = customer;
        mediator.Programmer = programmer;
        mediator.Tester = tester;
        customer.Send("Есть заказ, надо сделать программу");
        programmer.Send("Программа готова, надо протестировать");
        tester.Send("Программа протестирована и готова к продаже");

        Assert.IsTrue(mediator.Customer is Colleague);
    }
}