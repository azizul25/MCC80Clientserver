using API.Contracts;
using API.DTOs.EducationDto;
using FluentValidation;

namespace API.Utilities.Validations.Education;

public class NewEducationValidations : AbstractValidator<NewEducationDto>
{
    private readonly IEducationRepository _educationRepository;

    public NewEducationValidations(IEducationRepository educationRepository)
    {
        _educationRepository = educationRepository;

        RuleFor(ed => ed.Major)
            .NotEmpty();


        RuleFor(ed => ed.Degree)
            .NotEmpty();

        RuleFor(ed => ed.GPA)
           .NotEmpty();




    }


}