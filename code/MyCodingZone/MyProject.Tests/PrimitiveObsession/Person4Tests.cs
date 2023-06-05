using MyProject.Lib.PrimitiveObsession;

namespace MyProject.Tests.PrimitiveObsession;

public class Person4Tests
{
    [Fact]
    public void Formatting_happy_case()
    {
        var person = new Person4("Homer", "Simpson");

        person.Format().Should().Be("Homer Simpson");
    }
}