using API.Contracts;
using API.DTOs.RoomDto;
using FluentValidation;

namespace API.Utilities.Validations.Room;

public class NewRoomValidations : AbstractValidator<NewRoomDto>
{
    private readonly IRoomRepository _roomrepository;

    public NewRoomValidations(IRoomRepository roomRepository)
    {
        _roomrepository = roomRepository;

        RuleFor(r => r.Name)
            .NotEmpty()
        .Must(IsDulpicateValue).WithMessage("name room already exits");

        RuleFor(r => r.Floor)
            .NotEmpty();

        RuleFor(r => r.Capacity)
       .NotEmpty();
     

    }

    private bool IsDulpicateValue(string arg)
    {
        return _roomrepository.IsNotExist(arg);
    }
}