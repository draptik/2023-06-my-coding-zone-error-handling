using MyProject.Lib.ValueObjects.MoneyExample;

namespace MyProject.Tests.ValueObjects.MoneyExample;

public class MoneyTests
{
    [Fact]
    public void Money_happy_case()
    {
        var money = new Money(42, Currency.EUR);

        money.Amount.Should().Be(42);
        money.Currency.Should().Be(Currency.EUR);
    }
    
    [Fact]
    public void Money_equality()
    {
        var money1 = new Money(42, Currency.EUR);
        var money2 = new Money(42, Currency.EUR);

        money1.Should().Be(money2);
    }
    
    [Fact]
    public void Money_adding_different_currencies_fails()
    {
        var money1 = new Money(42, Currency.EUR);
        var money2 = new Money(42, Currency.USD);

        Action action = () => money1.Add(money2);

        action.Should().Throw<CurrenciesDontMatchException>();
    }
    
    [Fact]
    public void Money_subtracting_different_currencies_fails()
    {
        var money1 = new Money(42, Currency.EUR);
        var money2 = new Money(42, Currency.USD);

        Action action = () => money1.Subtract(money2);

        action.Should().Throw<CurrenciesDontMatchException>();
    }
    
    [Fact]
    public void Money_adding()
    {
        var money1 = new Money(42, Currency.EUR);
        var money2 = new Money(42, Currency.EUR);

        var result = money1.Add(money2);

        result.Should().Be(new Money(84, Currency.EUR));
    }
    
    [Fact]
    public void Money_subtracting()
    {
        var money1 = new Money(42, Currency.EUR);
        var money2 = new Money(42, Currency.EUR);

        var result = money1.Subtract(money2);

        result.Should().Be(new Money(0, Currency.EUR));
    }
    
    [Fact]
    public void Money_subtracting_to_negative_amount_fails()
    {
        var money1 = new Money(42, Currency.EUR);
        var money2 = new Money(43, Currency.EUR);

        Action action = () => money1.Subtract(money2);

        action.Should().Throw<MoneyCannotBeNegativeException>();
    }
}