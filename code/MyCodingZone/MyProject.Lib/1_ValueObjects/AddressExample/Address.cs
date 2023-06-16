namespace MyProject.Lib._1_ValueObjects.AddressExample;

public class Address
{
    private readonly Country _country;
    private readonly City _city;
    private readonly ZipCode _zipCode;
    private readonly Street _street;

    public string Country => _country.Value;

    public string City => _city.Value;

    public string ZipCode => _zipCode.Value;

    public string Street => _street.ToString();

    public Address(Country country, City city, ZipCode zipCode, Street street)
    {
        _country = country;
        _city = city;
        _zipCode = zipCode;
        _street = street;
    }

    public override bool Equals(object? obj)
    {
        if (obj is not Address other)
        {
            return false;
        }

        return other.Country == Country &&
               other.City == City &&
               other.ZipCode == ZipCode &&
               other.Street == Street;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Country, City, ZipCode, Street);
    }
    
    public static bool operator ==(Address left, Address right)
    {
        return Equals(left, right);
    }

    public static bool operator !=(Address left, Address right)
    {
        return !(left == right);
    }
}

public class Street
{
    public string Name { get; }
    public string Number { get; }

    public Street(string name, string number)
    {
        Name = name;
        Number = number;
    }

    public override bool Equals(object? obj)
    {
        if (obj is not Street other)
        {
            return false;
        }

        return other.Name == Name &&
               other.Number == Number;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Name, Number);
    }

    public override string ToString()
    {
        return $"{Name} {Number}";
    }
}

public class ZipCode
{
    public string Value { get; }

    public ZipCode(string value)
    {
        Value = value;
    }
    
    
    public override bool Equals(object? obj)
    {
        if (obj is not ZipCode other)
        {
            return false;
        }

        return other.Value == Value;
    }

    public override int GetHashCode()
    {
        unchecked
        {
            int hash = 17;
            hash = hash * 23 + (Value.GetHashCode());
            return hash;
        }
    }
}

public class City
{    
    public string Value { get; }

    public City(string value)
    {
        Value = value;
    }

    public override bool Equals(object? obj)
    {
        if (obj is not City other)
        {
            return false;
        }

        return other.Value == Value;
    }

    public override int GetHashCode()
    {
        unchecked
        {
            int hash = 17;
            hash = hash * 23 + (Value.GetHashCode());
            return hash;
        }
    }
}

public class Country
{
    public string Value { get; }

    public Country(string value)
    {
        Value = value;
    }
    
    public override bool Equals(object? obj)
    {
        if (obj is not Country other)
        {
            return false;
        }

        return other.Value == Value;
    }

    public override int GetHashCode()
    {
        unchecked
        {
            int hash = 17;
            hash = hash * 23 + (Value.GetHashCode());
            return hash;
        }
    }
}