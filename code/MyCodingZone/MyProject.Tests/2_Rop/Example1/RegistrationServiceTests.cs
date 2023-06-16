using CSharpFunctionalExtensions;
using MyProject.Lib._2_Rop.Example1;
using NSubstitute;

namespace MyProject.Tests._2_Rop.Example1;

public class RegistrationServiceTests
{
    private readonly Customer _customer;
    private readonly IMailService _mailService;
    private readonly ICustomerRepository _customerRepository;

    public RegistrationServiceTests()
    {
        _customer = SetupDefaultCustomer();
        _mailService = SetupMailService(_customer);
        _customerRepository = SetupCustomerRepository(_customer);
    }
    
    [Fact]
    public void Registering_valid_customer_primitive_happy_path_works()
    {
        // Arrange
        var sut = new RegistrationService(_customerRepository, _mailService);

        // Act
        var result = sut.RegisterNewCustomer_NoError_Handling("valid");

        // Assert
        result.Should()
            .BeEquivalentTo(RegistrationResponse.Success(_customer));
    }
    
    [Fact]
    public void Registering_valid_customer_long_error_handling_works()
    {
        // Arrange
        var sut = new RegistrationService(_customerRepository, _mailService);

        // Act
        var result = sut.RegisterNewCustomer_Error_Handling1("valid");

        // Assert
        result.Should()
            .BeEquivalentTo(RegistrationResponse.Success(_customer));
    }
    
    
    [Fact]
    public void Registering_valid_customer_happy_path_works()
    {
        // Arrange
        var sut = new RegistrationService(_customerRepository, _mailService);

        // Act
        var result = sut.RegisterNewCustomer_Error_Handling2("valid");

        // Assert
        result.Should()
            .BeEquivalentTo(RegistrationResponse.Success(_customer));
    }
    
    [Fact]
    public void Registering_invalid_customer_should_have_correct_error()
    {
        // Arrange
        var sut = new RegistrationService(_customerRepository, _mailService);

        // Act
        var result = sut.RegisterNewCustomer_Error_Handling2("");

        // Assert
        result.Should()
            .BeEquivalentTo(RegistrationResponse.Fail("invalid name"));
    }
    
    [Fact]
    public void Registering_with_repository_error_should_have_correct_error()
    {
        // Arrange
        var sut = new RegistrationService(_customerRepository, _mailService);
        _customerRepository
            .Save(Arg.Any<Customer>())
            .Returns(Result.Failure<Customer>("repo error"));

        // Act
        var result = sut.RegisterNewCustomer_Error_Handling2("valid");

        // Assert
        result.Should()
            .BeEquivalentTo(RegistrationResponse.Fail("repo error"));
    }
    
    [Fact]
    public void Registering_with_mailer_error_should_have_correct_error()
    {
        // Arrange
        var sut = new RegistrationService(_customerRepository, _mailService);
        _mailService
            .SendGreeting(Arg.Any<Customer>())
            .Returns(Result.Failure<Customer>("mailer error"));

        // Act
        var result = sut.RegisterNewCustomer_Error_Handling2("valid");

        // Assert
        result.Should()
            .BeEquivalentTo(RegistrationResponse.Fail("mailer error"));
    }
    private static ICustomerRepository SetupCustomerRepository(Customer customer)
    {
        var customerRepository = Substitute.For<ICustomerRepository>();
        customerRepository
            .Save(Arg.Any<Customer>())
            .Returns(Result.Success(customer));
        return customerRepository;
    }

    private static IMailService SetupMailService(Customer customer)
    {
        var mailService = Substitute.For<IMailService>();
        mailService
            .SendGreeting(Arg.Any<Customer>())
            .Returns(Result.Success(customer));
        return mailService;
    }

    private static Customer SetupDefaultCustomer() =>
        CustomerName.TryCreate("ok")
            .Match(
                onSuccess: x => new Customer(x),
                onFailure: _ => throw new Exception());
}