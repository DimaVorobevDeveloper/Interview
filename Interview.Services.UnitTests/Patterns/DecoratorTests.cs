using Interview.Services.Patterns.Decorator;

namespace Interview.Services.UnitTests.Patterns;

[TestClass]
public class DecoratorTests
{
    [TestMethod]
    public void Do()
    {
        Pizza pizza1 = new ItalianPizza(); // сначала инициализируем итальянскую пиццу
        
        Assert.AreEqual("Итальянская пицца", pizza1.Name);
        Assert.AreEqual(10, pizza1.GetCost());

        pizza1 = new TomatoPizza(pizza1); // итальянская пицца с томатами
        Assert.AreEqual("Итальянская пицца, с томатами", pizza1.Name);
        Assert.AreEqual(13, pizza1.GetCost());

        Pizza pizza2 = new ItalianPizza();
        pizza2 = new CheesePizza(pizza2);// итальянская пиццы с сыром
        Assert.AreEqual("Итальянская пицца, с сыром", pizza2.Name);
        Assert.AreEqual(15, pizza2.GetCost());

        Pizza pizza3 = new BulgerianPizza();
        pizza3 = new TomatoPizza(pizza3);
        pizza3 = new CheesePizza(pizza3);// болгарская пиццы с томатами и сыром
        Assert.AreEqual("Болгарская пицца, с томатами, с сыром", pizza3.Name);
        Assert.AreEqual(16, pizza3.GetCost());
    }
}
