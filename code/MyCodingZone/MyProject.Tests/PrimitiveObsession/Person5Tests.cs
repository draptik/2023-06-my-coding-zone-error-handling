using FluentAssertions.Execution;
using MyProject.Lib.PrimitiveObsession;

namespace MyProject.Tests.PrimitiveObsession;

public class Person5Tests
{
    [Fact]
    public void Create_person_with_first_and_last_name()
    {
        var person = new Person5(new FirstName("Homer"), new LastName("Simpson"));

        using (new AssertionScope())
        {
            person.FirstName.Should().Be(new FirstName("Homer"));
            person.LastName.Should().Be(new LastName("Simpson"));    
        }
    }
}