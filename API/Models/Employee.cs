using API.Utilities.Enums;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Models;
[Table("tb_m_employees")]
public class Employee : BaseEntity
{
    [Column("nik", TypeName = "nchar(6)")]
    public String Nik { get; set; }
    [Column("firsname", TypeName = "nvarchar(100)")]
    public String FirstName { get; set; }
    [Column("lastname", TypeName = "nvarchar(100)")]
    public String? LastName { get; set; } //notnull
    [Column("birthdate")]
    public DateTime BirthDate { get; set; }
    [Column("gender")]
    public GenderLevel Gender { get; set; }
    [Column("hiringdate")]
    public DateTime HiringDate { get; set; }
    [Column("email", TypeName = "nvarchar(100)")]
    public String Email { get; set; }
    [Column("phonenumber", TypeName = "nvarchar(20)")]
    public String PhoneNumber { get; set; }


    //cardinall
    public Education? Educations { get; set; }
    public Account?  Accounts { get; set; }
    public ICollection<Booking>? Bookings { get; set; }

}
