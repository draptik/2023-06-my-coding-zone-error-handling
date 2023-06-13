namespace MyProject.Lib.ValueObjects.MoneyExample;

public class MoneyCannotBeNegativeException : Exception
{
    public MoneyCannotBeNegativeException(string message) : base(message)
    {
    }
}

public class CurrenciesDontMatchException : Exception
{
    public CurrenciesDontMatchException(string message) : base(message)
    {
    }
}