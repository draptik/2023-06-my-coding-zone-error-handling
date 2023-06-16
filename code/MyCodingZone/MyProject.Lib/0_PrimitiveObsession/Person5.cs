namespace MyProject.Lib._0_PrimitiveObsession;

public class Person5
{
    public Person5(FirstName firstName, LastName lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }

    public FirstName FirstName { get; }
    public LastName LastName { get; }
}

public record FirstName(string Value);
public record LastName(string Value);