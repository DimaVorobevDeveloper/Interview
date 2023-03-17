using Interview.Services.SynchronizationPrimitives;

namespace Interview.Services.UnitTests.SynchronizationPrimitives;

[TestClass]
public class DeadlockCaseOneTests
{
    [TestMethod]
    public void GetTest()
    {
        DeadlockCaseOne.Main();
    }
}