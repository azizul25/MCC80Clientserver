using API.Contracts;
using API.DTOs.AccountDto;
using FluentValidation;

namespace API.Utilities.Validations.account;

public class NewAccountValidations : AbstractValidator<NewAccountDto>
{
    private readonly IAccountRepository _accountrepository;

    public NewAccountValidations(IAccountRepository accountrepository)
    {
        _accountrepository = accountrepository;

        RuleFor(a => a.Password)
            .NotEmpty();

        RuleFor(a => a.Isused)
            .NotEmpty();
        RuleFor(a => a.Otp)
            .NotEmpty();

        RuleFor(a => a.EcpiredTime)
            .NotEmpty();


    }


}