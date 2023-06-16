using CSharpFunctionalExtensions;

namespace MyProject.Lib._2_Rop.Example1;

public interface ICustomerRepository
{
    Result<Customer> Save(Customer customer);
    
}