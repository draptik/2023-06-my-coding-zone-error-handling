namespace MyProject.Lib._1_ValueObjects.MoneyExample;

public class Money
{
    public Money(decimal amount, Currency currency)
    {
        if (amount < 0)
        {
            throw new MoneyCannotBeNegativeException($"Money cannot be negative: {amount}");
        }

        Amount = amount;
        Currency = currency;
    }

    public decimal Amount { get; }
    public Currency Currency { get; }
    
    public override bool Equals(object? obj)
    {
        if (obj is not Money other)
        {
            return false;
        }

        return Amount == other.Amount && Currency == other.Currency;
    }
    
    public override int GetHashCode()
    {
        return HashCode.Combine(Amount, Currency);
    }
    
    public static bool operator ==(Money left, Money right)
    {
        return Equals(left, right);
    }

    public static bool operator !=(Money left, Money right)
    {
        return !(left == right);
    }

    public Money Add(Money right)
    {
        if (Currency != right.Currency)
        {
            throw new CurrenciesDontMatchException("Cannot add money with different currencies");
        }

        return new Money(Amount + right.Amount, Currency);
    }
    
    public Money Subtract(Money right)
    {
        
        if (Currency != right.Currency)
        {
            throw new CurrenciesDontMatchException("Cannot subtract money with different currencies");
        }

        return new Money(Amount - right.Amount, Currency);
    }
    
    public static Money operator +(Money left, Money right)
    {
        return left.Add(right);
    }
    
    public static Money operator -(Money left, Money right)
    {
        return left.Subtract(right);
    }
}