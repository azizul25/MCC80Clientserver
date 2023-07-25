using API.DTOs.Accounts;
using FluentValidation;

namespace API.Utilities.Validations.Account;

public class LoginValidator : AbstractValidator<LoginDto>
{
    public LoginValidator()
    {
        RuleFor(a => a.Email).NotEmpty().EmailAddress();
        RuleFor(a => a.Password).NotEmpty();
    }
}
