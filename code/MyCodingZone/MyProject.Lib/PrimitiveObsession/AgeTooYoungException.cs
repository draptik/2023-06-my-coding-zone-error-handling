namespace MyProject.Lib.PrimitiveObsession;

public class AgeTooYoungException : Exception
{
    public AgeTooYoungException()
    {
    }

    public AgeTooYoungException(string message) : base(message)
    {
    }
}