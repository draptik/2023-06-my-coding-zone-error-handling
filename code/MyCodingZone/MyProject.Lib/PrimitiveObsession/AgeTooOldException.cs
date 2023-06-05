namespace MyProject.Lib.PrimitiveObsession;

public class AgeTooOldException : Exception
{
    public AgeTooOldException()
    {
    }

    public AgeTooOldException(string? message) : base(message)
    {
    }
}