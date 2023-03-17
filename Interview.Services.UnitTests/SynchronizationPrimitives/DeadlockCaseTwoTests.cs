using Interview.Services.SynchronizationPrimitives;

namespace Interview.Services.UnitTests.SynchronizationPrimitives;

[TestClass]
public class DeadlockCaseTwoTests
{
    [TestMethod]
    public void GetTest()
    {
        DeadlockCaseTwo.Main();
    }
}