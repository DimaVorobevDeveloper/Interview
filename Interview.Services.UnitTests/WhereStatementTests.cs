using Interview.Services.Linq;
using FluentAssertions;
using FluentAssertions.Execution;

namespace Interview.Services.UnitTests;

[TestClass]
public class WhereStatementTests
{
    [TestMethod]
    public void GetLessThanMaxTest()
    {
        List<int> list = new() { 1, 2, 3, 4, 5 };
        var m0 = WhereStatement.GetLessThanMax(list);
        var m1 = WhereStatement.GetLessThanMax(list, 3);
        var m2 = WhereStatement.GetLessThanMaxWithConsole(list);
        var m3 = WhereStatement.GetLessThanMaxWithConsole(list, 3);

        using (new AssertionScope())
        {
            m0.Count.Should().Be(4);
            m1.Count.Should().Be(4);
        }

        Assert.AreEqual(5, m0.Count);
        Assert.AreEqual(3, m1.Count);
        Assert.AreEqual(5, m2.Count);
        Assert.AreEqual(3, m3.Count);
    }

    [TestMethod]
    public void GetMoreThanMinTest()
    {
        List<int> list = new() { 1, 2, 3, 4, 5 };

        //var l0 = WhereStatement.GetMoreThanMin(list);
        //var l1 = WhereStatement.GetMoreThanMin(list, 3);
        //var l2 = WhereStatement.GetMoreThanMinWithConsole(list);
        //var l3 = WhereStatement.GetMoreThanMinWithConsole(list, 3);

        //Assert.AreEqual(5, l0.Count);
        //Assert.AreEqual(3, l1.Count);
        //Assert.AreEqual(5, l2.Count);
        //Assert.AreEqual(3, l3.Count);
    }
}
