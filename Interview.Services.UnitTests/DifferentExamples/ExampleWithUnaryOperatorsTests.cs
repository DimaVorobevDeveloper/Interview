using Interview.Services.DifferentExamples;

namespace Interview.Services.UnitTests.DifferentExamples;

[TestClass]
public class ExampleWithUnaryOperatorsTests
{
    [TestMethod]
    [DataRow(13, 0)]
    [DataRow(37, 8)]
    public void MultipleIncrementTest(int expected, int input)
    {
        var result = ExampleWithUnaryOperators.MultipleIncrement(input);
        Assert.AreEqual(expected, result);
    }

    [TestMethod]
    [DataRow(1, 0)]
    [DataRow(2, 1)]
    public void SingleIncrementTest(int expected, int input)
    {
        var result = ExampleWithUnaryOperators.SingleIncrement(input);

        Assert.AreEqual(expected, result);
    }
}
