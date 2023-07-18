using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Models;
[Table("tb_tr_accountroless")]
public class AccountRole : BaseEntity
{
    [Column("accountguid")]
    public Guid AccountGuid { get; set; }
    [Column("roleguid")]
    public Guid RoleGuid { get; set; }
}
