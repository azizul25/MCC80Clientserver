using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Models;
[Table("tb_m_roles")]
public class Role : BaseEntity
{
    [Column("name", TypeName = "nvarchar(100)")]
    public String Name { get; set; }
    //cedriblitas
    public ICollection<AccountRole>? AccountRoles { get; set; }
}
