using Interview.Services.SynchronizationPrimitives;

namespace Interview.Services.UnitTests.SynchronizationPrimitives;

internal class SynchronizationWithSemaphoreAndInterlockedTests
{
    [TestMethod]
    public void GetTest()
    {
        NoSynchronization.Main();
    }
}