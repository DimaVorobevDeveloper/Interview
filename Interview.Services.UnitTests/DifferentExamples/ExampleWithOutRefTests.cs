using Interview.Services.DifferentExamples;

namespace Interview.Services.UnitTests.DifferentExamples;

[TestClass]
public class ExampleWithOutRefTests
{
    [TestMethod]
    [DataRow(0, 222, 333, 0)]
    [DataRow(7, 222, 333, 7)]
    public void MultipleIncrementTest(int expectedResult1, int expectedResult2, int expectedResult3, int input)
    {
        var result = ExampleWithOutRef.RunAllExamples(input);
        Assert.AreEqual((expectedResult1, expectedResult2, expectedResult3), result);
    }
}
