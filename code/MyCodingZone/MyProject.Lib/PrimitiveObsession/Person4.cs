namespace MyProject.Lib.PrimitiveObsession;

public class Person4
{
    public Person4(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }

    public string FirstName { get; }
    public string LastName { get; }

    public string Format() => $"{FirstName} {LastName}";
}
