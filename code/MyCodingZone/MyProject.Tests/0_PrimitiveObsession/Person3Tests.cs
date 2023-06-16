using MyProject.Lib._0_PrimitiveObsession;

namespace MyProject.Tests._0_PrimitiveObsession;

public class Person3Tests
{
    [Fact]
    public void Age_happy_case()
    {
        var person = new Person3(new Age2(42));

        person.Age.Value.Should().Be(42);
    }
    
    // [Fact]
    // public void Age2_is_immutable()
    // {
    //     var age = new Age2(42);
    //
    //     // Won't compile:
    //     Action action = () => age.Value = 43;
    //
    //     action.Should().Throw<InvalidOperationException>();
    // }
}