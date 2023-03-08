using Interview.Services.SynchronizationPrimitives;

namespace Interview.Services.UnitTests.SynchronizationPrimitives;

[TestClass]
public class NoSynchronizationTests
{
    [TestMethod]
    public void GetTest()
    {
        NoSynchronization.Main();
    }
}