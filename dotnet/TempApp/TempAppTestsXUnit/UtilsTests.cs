using Xunit;

public class UtilsTests
{
    [Fact]
    public void Test1()
    {
        Assert.True(true);
    }

    [Fact]
    public void ComputeHash_ReturnsCorrectHash()
    {
        string result = Utils.ComputeHash("test", null);
        Assert.Equal("098f6bcd4621d373cade4e832627b4f6", result);
    }
}