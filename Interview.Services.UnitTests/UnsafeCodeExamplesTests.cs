using Interview.Services.WorkWithMemory;

namespace Interview.Services.UnitTests;

[TestClass]
public class UnsafeCodeExamplesTests
{
    [TestMethod]
    public void Do()
    {
        var firstChar = '*';
        var inputValue = firstChar + "1234";
        var targetChar = '$';
        var expected = UnsafeCodeExamples.ChangeFirstCharAddressInMemory(inputValue, targetChar);

        Assert.AreNotEqual(firstChar, targetChar);
        Assert.AreEqual(firstChar, '*');
        Assert.AreEqual(targetChar, '$');
        Assert.AreEqual(inputValue[0], targetChar);
        Assert.AreEqual(expected[0], targetChar);
        Assert.AreEqual(expected, inputValue);
    }
}