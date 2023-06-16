using MyProject.Lib._0_PrimitiveObsession;

namespace MyProject.Tests._0_PrimitiveObsession;

public class Person4Tests
{
    [Fact]
    public void Formatting_happy_case()
    {
        var person = new Person4("Homer", "Simpson");

        person.Format().Should().Be("Homer Simpson");
    }
}