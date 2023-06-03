namespace MyProject.Lib.PrimitiveObsession;

public class Person1
{
    private const int MinAge = 0;
    private const int MaxAge = 150;
    
    private readonly int _age;

    public Person1(int age)
    {
        if (age > MaxAge)
        {
            throw new AgeTooOldException();
        }
        
        if (age <= MinAge)
        {
            throw new AgeTooYoungException();
        }
        
        _age = age;
    }

    public int Age => _age;
}