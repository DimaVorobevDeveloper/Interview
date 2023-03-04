using Interview.Services.Patterns.Singleton;

namespace Interview.Services.UnitTests.Patterns;

[TestClass]
public class SingletonTests
{
    [TestMethod]
    public void Do()
    {
        var singleton = Singleton.GetInstance();
        singleton.Log();

        var newSingleton = Singleton.GetInstance();

        Assert.AreEqual(singleton.GetHashCode(), newSingleton.GetHashCode());
        Assert.IsTrue(singleton.Equals(newSingleton));
    }
}