using MyProject.Lib._0_PrimitiveObsession;

namespace MyProject.Tests._0_PrimitiveObsession;

public class Person2Tests
{
    [Fact]
    public void Age_happy_case()
    {
        var person = new Person2(new Age(42));

        person.Age.Value.Should().Be(42);
    }

    // invalid age values are now impossible to create
    [Fact]
    public void Age_too_young()
    {
        Action action = () => new Age(-1);

        action.Should().Throw<AgeTooYoungException>();
    }

    [Fact]
    public void Age_too_old()
    {
        Action action = () => new Age(151);

        action.Should().Throw<AgeTooOldException>();
    }
}