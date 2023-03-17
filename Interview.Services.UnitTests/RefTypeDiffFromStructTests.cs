using Interview.Services.WorkWithMemory;

namespace Interview.Services.UnitTests;


[TestClass]
public class RefTypeDiffFromStructTests
{
    [TestMethod]
    public void Do()
    {
        var refAdnValueType = RefTypeDiffFromStruct.BoxStructAndCompareWithRefType();
        Assert.AreEqual(3, refAdnValueType.RefVal);
        Assert.AreEqual(2, refAdnValueType.ValueVal);
    }
}
