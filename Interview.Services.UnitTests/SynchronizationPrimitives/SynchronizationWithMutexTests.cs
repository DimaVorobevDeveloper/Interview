using Interview.Services.SynchronizationPrimitives;

namespace Interview.Services.UnitTests.SynchronizationPrimitives;

internal class SynchronizationWithMutexTests
{
    [TestMethod]
    public void GetTest()
    {
        NoSynchronization.Main();
    }
}