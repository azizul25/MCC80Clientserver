using API.Contracts;
using API.DTOs.EmployeeDto;
using FluentValidation;

namespace API.Utilities.Validations.Employee;

public class NewRoomValidations : AbstractValidator<NewEmployeeDto>
{
    private readonly IEmployeeRepository _employeerepository;

    public NewRoomValidations(IEmployeeRepository employeeRepository)
    {
        _employeerepository = employeeRepository;   

        RuleFor(e => e.Nik)
            .NotEmpty()
            .MaximumLength(6);
        RuleFor(e => e.FirstName)
            .NotEmpty();
        RuleFor(e => e.BirthDate)
       .NotEmpty()
       .LessThanOrEqualTo(DateTime.Now.AddYears(-10));

        RuleFor(e => e.Gender)
            .NotNull()
            .IsInEnum();

        RuleFor(e => e.HiringDate)
       .NotEmpty();

        RuleFor(e => e.Email)
            .NotEmpty().WithMessage("Email required")
            .EmailAddress().WithMessage("Email required")
            .Must(IsDulpicateValue).WithMessage("Email already exits");

        RuleFor(e => e.PhoneNumber)
            .NotEmpty()
            .MaximumLength(20)
            .Matches(@"^\+[0-9]+$")
        .Must(IsDulpicateValue).WithMessage("phone number already exits");
    }

    private bool IsDulpicateValue(string arg)
    {
        return _employeerepository.IsNotExist(arg);
    }
}