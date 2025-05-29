namespace GraphPathFinderCli.XUnit.UnitTests;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        Program p = new(42);
        Assert.Equal(42, p.I);
    }
}