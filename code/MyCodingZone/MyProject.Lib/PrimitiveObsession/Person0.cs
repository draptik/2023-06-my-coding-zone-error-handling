namespace MyProject.Lib.PrimitiveObsession;

public class Person0
{
    private const int MinAge = 0;
    private const int MaxAge = 150;
    
    private int _age;

    public int Age
    {
        get => _age;
        set
        {
            if (value > MaxAge)
            {
                throw new AgeTooOldException();
            }

            if (value <= MinAge)
            {
                throw new AgeTooYoungException();
            }
            
            _age = value;
        }
    }
}

// create a class Person1 with a property Age of type int which only accepts values between 0 and 150