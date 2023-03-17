using Interview.Services.SynchronizationPrimitives;

namespace Interview.Services.UnitTests.SynchronizationPrimitives;

[TestClass]
public class SynchronizationWithAutoResetEventTests
{
    [TestMethod]
    public void GetTest()
    {
        SynchronizationWithAutoResetEvent.Main();
    }
}