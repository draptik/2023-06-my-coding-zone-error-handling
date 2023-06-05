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
