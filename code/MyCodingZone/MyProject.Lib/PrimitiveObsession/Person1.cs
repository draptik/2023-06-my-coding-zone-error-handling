namespace MyProject.Lib.PrimitiveObsession;

public class Person1
{
    private const int MinAge = 0;
    private const int MaxAge = 150;

    public Person1(int age)
    {
        if (age > MaxAge)
        {
            throw new AgeTooOldException($"Age cannot be greater than {MaxAge}. Age provided: {age}");
        }

        if (age <= MinAge)
        {
            throw new AgeTooYoungException($"Age cannot be less than or equal to {MinAge}. Age provided: {age}");
        }

        Age = age;
    }

    public int Age { get; }
}