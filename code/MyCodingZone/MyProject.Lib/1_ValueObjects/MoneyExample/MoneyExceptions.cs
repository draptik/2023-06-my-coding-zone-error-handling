namespace MyProject.Lib._1_ValueObjects.MoneyExample;

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