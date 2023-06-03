using MyProject.Lib;

namespace MyProject.Tests;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        true.Should().BeTrue();
    }
    [Fact]
    public void Test2()
    {
        Class1.Dummy().Should().Be("Hello World!");
    }
}