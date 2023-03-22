namespace Interview.Services.UnitTests;

[TestClass]
public class WorkWithCollectionTests
{
    [TestMethod]
    public void T()
    {
        var workWithCollection = new WorkWithCollection();
        var result = workWithCollection.RemoveMiddleValueFromList(1);
        Assert.AreEqual(377, result);
    }
}