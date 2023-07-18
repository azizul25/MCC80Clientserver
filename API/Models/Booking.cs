using API.Utilities.Enums;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Models;
[Table("tb_tr_bookings")]
public class Booking : BaseEntity
{
    [Column("stardate")]
    public DateTime StarDate { get; set; }
    [Column("enddate")]
    public DateTime EndDate { get; set; }
    [Column("status")]
    public StatusLevel Status { get; set; }
    [Column("remaks")]
    public String Remarks { get; set; }
    [Column("capacity")]
    public int Capacity { get; set; }
    [Column("roomguid")]
    public Guid RoomGuid { get; set; }
    [Column("employeeguid")]
    public Guid EmployeeGuid { get; set; }

}
