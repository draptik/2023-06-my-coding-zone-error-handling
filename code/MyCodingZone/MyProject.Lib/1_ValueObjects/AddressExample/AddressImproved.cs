using CSharpFunctionalExtensions;

namespace MyProject.Lib._1_ValueObjects.AddressExample;

public class AddressImproved : ValueObject
{
    public string Street { get; }
    public string City { get; }
    protected override IEnumerable<IComparable> GetEqualityComponents()
    {
        yield return Street;
        yield return City;
    }
}