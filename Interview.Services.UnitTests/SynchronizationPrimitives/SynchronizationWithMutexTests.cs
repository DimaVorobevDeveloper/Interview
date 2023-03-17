using Interview.Services.SynchronizationPrimitives;

namespace Interview.Services.UnitTests.SynchronizationPrimitives;

[TestClass]
public class SynchronizationWithMutexTests
{
    [TestMethod]
    public void GetTest()
    {
        SynchronizationWithMutex.Main();
    }
}