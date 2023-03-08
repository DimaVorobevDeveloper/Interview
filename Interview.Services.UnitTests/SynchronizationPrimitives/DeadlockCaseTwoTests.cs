using Interview.Services.SynchronizationPrimitives;

namespace Interview.Services.UnitTests.SynchronizationPrimitives;

internal class DeadlockCaseTwoTests
{
    [TestMethod]
    public void GetTest()
    {
        NoSynchronization.Main();
    }
}