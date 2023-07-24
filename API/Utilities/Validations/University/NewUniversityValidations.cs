using API.Contracts;
using API.DTOs.UniversityDto;
using FluentValidation;

namespace API.Utilities.Validations.University;

public class NewEducationValidations : AbstractValidator<NewUniversityDto>
{
    private readonly IUniversityRepository _universityrepository;

    public NewEducationValidations(IUniversityRepository universityrepository)
    {
        _universityrepository = universityrepository;

        RuleFor(u => u.Name)
            .NotEmpty()
            .Must(IsDulpicateValue).WithMessage("name university already exits");

        RuleFor(u => u.Code)
            .NotEmpty()
            .Must(IsDulpicateValue).WithMessage("code university already exits");



    }

    private bool IsDulpicateValue(string arg)
    {
        return _universityrepository.IsNotExist(arg);
    }
}