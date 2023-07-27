using API.Utilities.Enums;

namespace API.DTOs.BookingDto;

public class BookingDetailDTO
{
    //Employee
    public Guid BookingGuid { get; set; }
    public string BookedNik { get; set; }
    public string BookedBy { get; set; }

    //Room
    public string RoomName { get; set; }

    //Booking
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public StatusLevel Status { get; set; }
    public string Remarks { get; set; }
}
