using Interview.Services.SynchronizationPrimitives;

namespace Interview.Services.UnitTests.SynchronizationPrimitives;

[TestClass]
public class SynchronizationWithSemaphoreAndInterlockedTests
{
    [TestMethod]
    public void GetTest()
    {
        SynchronizationWithSemaphoreAndInterlocked.Main();
    }
}