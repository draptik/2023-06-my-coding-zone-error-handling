using MyProject.Lib._0_PrimitiveObsession;

namespace MyProject.Tests._0_PrimitiveObsession;

public class Person0Tests
{
    [Fact]
    public void Age_happy_case()
    {
        var person = new Person0
        {
            Age = 42
        };

        person.Age.Should().Be(42);
    }

    [Fact]
    public void Age_too_young()
    {
        var person = new Person0();

        Action action = () => person.Age = -1;

        action.Should().Throw<AgeTooYoungException>();
    }

    [Fact]
    public void Age_too_old()
    {
        var person = new Person0();

        Action action = () => person.Age = 151;

        action.Should().Throw<AgeTooOldException>();
    }
}