# Agenda

## Avoid Primitive Obsession

Example: "Age" is not an integer. 

The number must be 

- positive 
- and below a certain realistic maximum age.

Other common examples are "Money" and "Date".

### Common strategies for avoiding primitive obsession

- Create a class for the value
- Use Value Objects (DDD)
- Use `records` as a lightweight replacement for classes
- Use a language with a more powerful type system (F#, Haskell, etc.)

## Use Value Objects

Value Objects:

- are immutable
- have no identity (f.ex. no "life cycle", database id, etc.)
- are compared by value
- should contain as much logic as possible!
    - f.ex. `Money` should contain `Add`, `Subtract`, etc.
    - This is how Object-Oriented Programming is supposed to be done!
    - This is the main difference between Value Objects and C# records and structs
- should be used for everything that is not an Entity

## Avoid Null

Null-Pointers are a pain in any language. You never know what went wrong.

### Example 1

A C# method might have a signature like this:

```csharp
public Customer GetCustomerById(int id)
```

As consumer of this method:

- what if the customer does not exist? Should we return `null`? Or throw an exception?
- What happens if the database is down? 
- What happens if the customer is deleted while we are reading it?

### Example 2

```csharp
public static double DivideBy(int a, int b)
```

Hint: It does not magically become better by adding a `?`:

```csharp
public static double? DivideBy(int a, int b)
```

Sure, in this case we get an `CantDivideByZeroException`, but what if we divide by `null`?

### Common strategies for avoiding null

- Don't allow null as return type
- The consumer of the method should know what to expect
- Make the return type explicit (!):
  - Use a dedicated type for "no result"
    - This way we can distinguish between "no result" and "error".
    - F.ex. `Option<T>` in F# or `Maybe<T>` in Haskell
    - In C#:
      - `Maybe<T>` from [CSharpFunctionalExtensions](https://github.com/vkhorikov/CSharpFunctionalExtensions)
      - `Option<T>` from [LanguageExt](https://github.com/louthy/language-ext)
    - more on Functional Programming later...

## Avoid Exceptions for Control Flow

Exceptions are for exceptional situations. They should not be used for control flow.

Period.

## Workflows should show the happy path

This example is what we are trying to avoid:

```csharp
public void Checkout(int productId, int customerId)
{
    var product = _productRepository.GetById(productId);
    if (product == null)
    {
        throw new ProductNotFoundException(productId);
    }

    var customer = _customerRepository.GetById(customerId);
    if (customer == null)
    {
        throw new CustomerNotFoundException(customerId);
    }

    var order = new Order(customer, product);
    _orderRepository.Add(order);

    _paymentService.Pay(customer, order);
    //
    // ...
    // who cares about delivery?! As long as we got the money...
}
```

Above workflow is hard to read and understand. It is not obvious what the happy path is.

The same workflow using a functional approach, with method chaining, using CSharpFunctionalExtensions:

```csharp
public Result Checkout(int productId, int customerId)
{
    return Result
        .Success()
        .Ensure(() => _productRepository.GetById(productId) != null, $"Product with id {productId} was not found")
        .Ensure(() => _customerRepository.GetById(customerId) != null, $"Customer with id {customerId} was not found")
        .Map(() => new Order(customer, product))
        .Tap(order => _orderRepository.Add(order))
        .Tap(order => _paymentService.Pay(customer, order));
}
```