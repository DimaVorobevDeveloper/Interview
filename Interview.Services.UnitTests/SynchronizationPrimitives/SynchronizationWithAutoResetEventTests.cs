using Interview.Services.SynchronizationPrimitives;

namespace Interview.Services.UnitTests.SynchronizationPrimitives;

internal class SynchronizationWithAutoResetEventTests
{
    [TestMethod]
    public void GetTest()
    {
        NoSynchronization.Main();
    }
}