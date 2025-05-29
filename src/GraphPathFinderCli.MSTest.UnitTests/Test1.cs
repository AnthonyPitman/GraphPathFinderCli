namespace GraphPathFinderCli.MSTest.UnitTests;

[TestClass]
public sealed class Test1
{
    [TestMethod]
    public void TestMethod1()
    {
        Program p = new(42);
        Assert.AreEqual(42, p.I);
    }
}