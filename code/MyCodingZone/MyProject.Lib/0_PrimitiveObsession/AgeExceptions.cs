namespace MyProject.Lib._0_PrimitiveObsession;

public class AgeTooOldException : Exception
{
    public AgeTooOldException()
    {
    }

    public AgeTooOldException(string? message) : base(message)
    {
    }
}

public class AgeTooYoungException : Exception
{
    public AgeTooYoungException()
    {
    }

    public AgeTooYoungException(string message) : base(message)
    {
    }
}