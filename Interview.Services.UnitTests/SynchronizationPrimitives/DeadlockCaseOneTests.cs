using Interview.Services.SynchronizationPrimitives;

namespace Interview.Services.UnitTests.SynchronizationPrimitives;

internal class DeadlockCaseOneTests
{
    [TestMethod]
    public void GetTest()
    {
        NoSynchronization.Main();
    }
}