using MyProject.Lib._1_ValueObjects.AddressExample;

namespace MyProject.Tests._1_ValueObjects.AddressExample;

public class AddressTests
{
    [Fact]
    public void Address_equality_works()
    {
        var homerAddress = new Address(
            new Country("USA"),
            new City("Springfield"),
            new ZipCode("12345"),
            new Street("Evergreen Terrace", "42"));
        
        var lisaAddress = new Address(
            new Country("USA"),
            new City("Springfield"),
            new ZipCode("12345"),
            new Street("Evergreen Terrace", "42"));

        var simpsonAddressesAreEqual = homerAddress == lisaAddress;

        simpsonAddressesAreEqual.Should().BeTrue("both Addresses are the same");
    }
}