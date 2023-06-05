# README

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
