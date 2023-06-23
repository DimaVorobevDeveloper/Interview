using Interview.Services.Patterns.Observer;

namespace Interview.Services.UnitTests.Patterns;

[TestClass]
public class ObserverTests
{
    [TestMethod]
    public void Do()
    {
        Stock stock = new Stock();
        Bank bank = new Bank("ЮнитБанк", stock);
        Broker broker = new Broker("Иван Иваныч", stock);

        // имитация торгов
        stock.Market();

        // брокер прекращает наблюдать за торгами
        broker.StopTrade();

        // имитация торгов
        stock.Market();
    }
}
