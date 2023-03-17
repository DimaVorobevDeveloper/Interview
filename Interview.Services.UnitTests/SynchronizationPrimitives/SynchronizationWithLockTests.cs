using Interview.Services.SynchronizationPrimitives;

namespace Interview.Services.UnitTests.SynchronizationPrimitives;

[TestClass]
public class SynchronizationWithLockTests
{
    [TestMethod]
    public void GetTest()
    {
        SynchronizationWithLock.Main();
    }
}