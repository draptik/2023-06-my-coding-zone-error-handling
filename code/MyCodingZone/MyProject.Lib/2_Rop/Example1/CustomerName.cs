using CSharpFunctionalExtensions;

namespace MyProject.Lib._2_Rop.Example1;

public class CustomerName
{
    public string Value { get; }

    private CustomerName(string value) => Value = value;

    public static Maybe<CustomerName> MaybeCreate(string name)
        => string.IsNullOrWhiteSpace(name)
            ? Maybe<CustomerName>.None
            : Maybe.From(new CustomerName(name));

    
    
    
    
    
    public static Result<CustomerName> TryCreate(string name)
        => string.IsNullOrWhiteSpace(name)
            ? Result.Failure<CustomerName>("invalid name")
            : Result.Success(new CustomerName(name));
}