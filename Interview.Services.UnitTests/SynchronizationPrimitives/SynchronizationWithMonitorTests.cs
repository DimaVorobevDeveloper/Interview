using Interview.Services.SynchronizationPrimitives;

namespace Interview.Services.UnitTests.SynchronizationPrimitives;

internal class SynchronizationWithMonitorTests
{
    [TestMethod]
    public void GetTest()
    {
        NoSynchronization.Main();
    }
}