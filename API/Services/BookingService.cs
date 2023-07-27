using API.Contracts;
using API.DTOs.BookingDto;
using API.Models;
namespace API.Services;

public class BookingService
{
    private readonly IBookingRepository _bookingRepository;
    private readonly IEmployeeRepository _employeeRepository;
    private readonly IRoomRepository _roomRepository;
    public BookingService(IBookingRepository bookingRepository, IEmployeeRepository employeeRepository, IRoomRepository roomRepository)
    {
        _bookingRepository = bookingRepository;
        _employeeRepository = employeeRepository;
        _roomRepository = roomRepository;
    }

    public IEnumerable<BookingDto> GetAll()
    {
        var bookings = _bookingRepository.GetAll();
        if (!bookings.Any())
        {
            return Enumerable.Empty<BookingDto>(); // Booking is null or not found;
        }

        var bookingDtos = new List<BookingDto>();
        foreach (var booking in bookings)
        {
            bookingDtos.Add((BookingDto)booking);
        }

        return bookingDtos; // Booking is found;
    }

    public BookingDto? GetByGuid(Guid guid)
    {
        var booking = _bookingRepository.GetByGuid(guid);
        if (booking is null)
        {
            return null; // Booking is null or not found;
        }

        return (BookingDto)booking; // Booking is found;
    }

    public BookingDto? Create(NewBookingDto newBookingDto)
    {
        var booking = _bookingRepository.Create(newBookingDto);
        if (booking is null)
        {
            return null; // Booking is null or not found;
        }

        return (BookingDto)booking; // Booking is found;
    }

    public int Update(BookingDto bookingDto)
    {
        var booking = _bookingRepository.GetByGuid(bookingDto.Guid);
        if (booking is null)
        {
            return -1; // Booking is null or not found;
        }

        Booking toUpdate = bookingDto;
        toUpdate.CreatedDate = booking.CreatedDate;
        var result = _bookingRepository.Update(toUpdate);

        return result ? 1 // Booking is updated;
            : 0; // Booking failed to update;
    }

    public int Delete(Guid guid)
    {
        var booking = _bookingRepository.GetByGuid(guid);
        if (booking is null)
        {
            return -1; // Booking is null or not found;
        }

        var result = _bookingRepository.Delete(booking);

        return result ? 1 // Booking is deleted;
            : 0; // Booking failed to delete;
    }


    public IEnumerable<BookingDetailDTO> GetAllDetailBooking()
    {
        var getDetail = (from booking in _bookingRepository.GetAll()
        join room in _roomRepository.GetAll() on booking.RoomGuid equals room.Guid
        join emplooyee in _employeeRepository.GetAll() on booking.EmployeeGuid equals emplooyee.Guid
                         select new BookingDetailDTO
                         {
                             BookingGuid = emplooyee.Guid,
                             BookedNik = emplooyee.Nik,
                             BookedBy = emplooyee.FirstName + " " + emplooyee.LastName,
                             RoomName = room.Name,
                             StartDate = booking.StarDate,
                             EndDate = booking.EndDate,
                             Status = booking.Status,
                             Remarks = booking.Remarks
                         });
        return getDetail;
    }

    public BookingDetailDTO? GetAllDetailBookingByGuid(Guid guid)
    {
        return GetAllDetailBooking().SingleOrDefault(b => b.BookingGuid == guid);
    }

  
}
