using MyProject.Lib.PrimitiveObsession;

namespace MyProject.Tests.PrimitiveObsession;

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
    
    // write a test for the AgeTooYoungException exception
    [Fact]
    public void Age_too_young()
    {
        var person = new Person0();
        
        Action action = () => person.Age = -1;
        
        action.Should().Throw<AgeTooYoungException>();
    }
    
    // write a test for the AgeTooOldException exception
    [Fact]
    public void Age_too_old()
    {
        var person = new Person0();
        
        Action action = () => person.Age = 151;
        
        action.Should().Throw<AgeTooOldException>();
    }
}