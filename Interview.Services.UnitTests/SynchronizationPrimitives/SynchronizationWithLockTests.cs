using Interview.Services.SynchronizationPrimitives;

namespace Interview.Services.UnitTests.SynchronizationPrimitives;

internal class SynchronizationWithLockTests
{
    [TestMethod]
    public void GetTest()
    {
        NoSynchronization.Main();
    }
}