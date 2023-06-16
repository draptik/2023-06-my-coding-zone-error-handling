using CSharpFunctionalExtensions;

namespace MyProject.Lib._2_Rop.Example1
{
    public class RegistrationService
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly IMailService _mailService;

        public RegistrationService(
            ICustomerRepository customerRepository,
            IMailService mailService)
        {
            _customerRepository = customerRepository;
            _mailService = mailService;
        }

        public RegistrationResponse RegisterNewCustomer_NoError_Handling(string name)
        {
            var maybeCustomerName = CustomerName.MaybeCreate(name);
            var customer = new Customer(maybeCustomerName.Value);

            var customerResult = _customerRepository.Save(customer);

            var greetingResult = _mailService.SendGreeting(customerResult.Value);

            return RegistrationResponse.Success(greetingResult.Value);
        }

        public RegistrationResponse RegisterNewCustomer_Error_Handling1(string name)
        {
            var customerNameResult = CustomerName.TryCreate(name);
            if (customerNameResult.IsFailure)
            {
                return RegistrationResponse.Fail(customerNameResult.Error);
            }

            var customer = new Customer(customerNameResult.Value);

            var customerResult = _customerRepository.Save(customer);
            if (customerResult.IsFailure)
            {
                return RegistrationResponse.Fail(customerResult.Error);
            }


            var greetingResult = _mailService.SendGreeting(customerResult.Value);
            if (greetingResult.IsFailure)
            {
                return RegistrationResponse.Fail(greetingResult.Error);
            }

            return RegistrationResponse.Success(greetingResult.Value);
        }

        public RegistrationResponse RegisterNewCustomer_Error_Handling2(string name)
        {
            var customerNameResult = CustomerName.TryCreate(name);

            var result = customerNameResult
                .Bind(x => Result.Ok(new Customer(x)))
                .Bind(x => _customerRepository.Save(x))
                .Bind(x => _mailService.SendGreeting(x))
                .Match(
                    onSuccess: x => RegistrationResponse.Success(x),
                    onFailure: e => RegistrationResponse.Fail(e));

            return result;
        }
    }
}
