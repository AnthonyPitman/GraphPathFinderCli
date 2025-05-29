namespace GraphPathFinderCli.NUnit.UnitTests;

[TestFixture]
public class Tests
{
    [Test]
    public void Test1()
    {
        Program p = new(42);
        Assert.That(p.I, Is.EqualTo(42));
    }
}