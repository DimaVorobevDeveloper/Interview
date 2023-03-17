using Interview.Services.SynchronizationPrimitives;

namespace Interview.Services.UnitTests.SynchronizationPrimitives;

[TestClass]
public class SynchronizationWithMonitorTests
{
    [TestMethod]
    public void GetTest()
    {
        SynchronizationWithMonitor.Main();
    }
}