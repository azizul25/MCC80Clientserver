using API.Contracts;
using API.DTOs.BookingDto;
using FluentValidation;

namespace API.Utilities.Validations.Booking;

public class NewBookingValidations : AbstractValidator<NewBookingDto>
{
    private readonly IBookingRepository _bookintorytorygrepository;

    public NewBookingValidations(IBookingRepository bookintorytorygrepository)
    {
        _bookintorytorygrepository = bookintorytorygrepository;


        RuleFor(b => b.Status)
            .NotEmpty();


        RuleFor(b => b.Remarks)
            .NotEmpty();

        RuleFor(b => b.StarDate)
            .NotEmpty()
            .LessThanOrEqualTo(DateTime.Now.AddHours(-5));

        RuleFor(b => b.EndDate)
          .NotEmpty();

    }


}