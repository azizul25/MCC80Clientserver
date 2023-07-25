using API.Contracts;
using API.DTOs.AccountDto;
using FluentValidation;

namespace API.Utilities.Validations.Account;

public class AccountValidator : AbstractValidator<AccountDto>
{ 
    private readonly IAccountRepository _accountRepository;
    public AccountValidator(IAccountRepository accountRepository)
    {
        _accountRepository = accountRepository;
        RuleFor(a => a.Guid).NotEmpty();
        RuleFor(a => a.Password).NotEmpty().Matches("^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$");
        RuleFor(a => a.Otp).NotEmpty();
        RuleFor(a => a.Isused).NotEmpty();
        RuleFor(a => a.EcpiredTime).NotEmpty().GreaterThanOrEqualTo(DateTime.Now);

    }
}
