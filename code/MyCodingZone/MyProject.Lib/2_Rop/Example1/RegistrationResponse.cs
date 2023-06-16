namespace MyProject.Lib._2_Rop.Example1;

public class RegistrationResponse
{
    public bool IsSuccess { get; }
    public Customer Customer { get; }
    public string Error { get; }

    private RegistrationResponse(bool success, Customer customer, string errorMsg)
    {
        Customer = customer;
        Error = errorMsg;
        IsSuccess = success;
    }

    public static RegistrationResponse Success(Customer customer)
    {
        return new RegistrationResponse(true, customer, null);
    }

    public static RegistrationResponse Fail(string errorMsg)
    {
        return new RegistrationResponse(false, null, errorMsg);
    }
}