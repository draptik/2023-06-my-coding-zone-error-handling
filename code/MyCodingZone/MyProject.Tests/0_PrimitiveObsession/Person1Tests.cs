using MyProject.Lib._0_PrimitiveObsession;

namespace MyProject.Tests._0_PrimitiveObsession;

public class Person1Tests
{
    [Fact]
    public void Age_happy_case()
    {
        var person = new Person1(42);

        person.Age.Should().Be(42);
    }

    [Fact]
    public void Age_too_young()
    {
        Action action = () => new Person1(-1);

        action.Should().Throw<AgeTooYoungException>();
    }

    [Fact]
    public void Age_too_old()
    {
        Action action = () => new Person1(151);

        action.Should().Throw<AgeTooOldException>();
    }
}