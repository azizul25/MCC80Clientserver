using API.Contracts;
using API.DTOs.RoleDto;
using FluentValidation;

namespace API.Utilities.Validations.Role;

public class NewRoleValidations : AbstractValidator<NewRoleDto>
{
    private readonly IRoleRepository _rolerepository;

    public NewRoleValidations(IRoleRepository roleRepository)
    {
        _rolerepository = roleRepository;

        RuleFor(r => r.Name)
            .NotEmpty()
            .Must(IsDulpicateValue).WithMessage("name role already exits");

        
       
    }

    private bool IsDulpicateValue(string arg)
    {
        return _rolerepository.IsNotExist(arg);
    }
}