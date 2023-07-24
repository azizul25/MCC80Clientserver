using API.Contracts;
using API.DTOs.AccountRoleDto;
using FluentValidation;

namespace API.Utilities.Validations.AccountRole;

public class NewAccountRoleValidations : AbstractValidator<NewAccountRoleDto>
{
    private readonly IAccountRoleRepository _accountrolerepository;

    public NewAccountRoleValidations(IAccountRoleRepository accountrolerepository)
    {
        _accountrolerepository = accountrolerepository;

        RuleFor(ar => ar.RoleGuid)
            .NotEmpty();


        RuleFor(ar => ar.AccountGuid)
            .NotEmpty();



    }

}