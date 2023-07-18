using API.Utilities.Enums;

namespace API.Models;

public class Booking : BaseEntity
{
   
    public DateTime StarDate { get; set; }
    public DateTime EndDate { get; set; }

    public StatusLevel Status { get; set; }
    public String Remarks { get; set; }
    public int Capacity { get; set; }
    public Guid RoomGuid { get; set; }
    public Guid EmployedGuid { get; set; }

}
