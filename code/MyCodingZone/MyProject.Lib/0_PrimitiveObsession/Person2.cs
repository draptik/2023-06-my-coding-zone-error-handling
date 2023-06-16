namespace MyProject.Lib._0_PrimitiveObsession;

// Person class should not have to validate age!
public class Person2
{
    public Person2(Age age)
    {
        Age = age;
    }

    public Age Age { get; }
}

// Age logic is now placed in Age class
public class Age
{
    private const int MinAge = 0;
    private const int MaxAge = 150;

    public Age(int value)
    {
        if (value > MaxAge)
        {
            throw new AgeTooOldException();
        }

        if (value <= MinAge)
        {
            throw new AgeTooYoungException();
        }

        Value = value;
    }

    public int Value { get; }
}
 