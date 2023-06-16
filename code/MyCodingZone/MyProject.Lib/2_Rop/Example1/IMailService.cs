using CSharpFunctionalExtensions;

namespace MyProject.Lib._2_Rop.Example1;

public interface IMailService
{
    Result<Customer> SendGreeting(Customer customer);
}