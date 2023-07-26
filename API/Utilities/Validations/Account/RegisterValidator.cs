using API.DTOs.Accounts;
using FluentValidation;

namespace API.Utilities.Validations.Account;


    public class RegisterValidator : AbstractValidator<RegisterDto>
    {
        public RegisterValidator()
        {

        }
    }
