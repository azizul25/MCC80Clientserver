using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Models;
[Table("tb_m_accounts")]
public class Account : BaseEntity
{
    [Column("password")]
    public String Password { get; set; }
    [Column("otp")]
    public int Otp { get; set; }
    [Column("isused")]
    public bool Isused { get; set; }
    [Column("ecpiredtime")]
    public DateTime EcpiredTime { get; set; }
    //cardinilitas
    public ICollection<AccountRole> AccountRoles { get; set; }
    public Employee? Employees { get; set; }

}
