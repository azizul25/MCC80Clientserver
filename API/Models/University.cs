using System.ComponentModel.DataAnnotations.Schema;

namespace API.Models;

[Table("tb_m_universities")]
public class University : BaseEntity
{
    [Column("code",TypeName ="nvarchar(50)")]
    public String Code { get; set; }
    [Column("name", TypeName = "nvarchar(100)")]
    public String Name { get; set; }
    //universitas punya banyak education
    public ICollection<Education>? Educations { get; set; }
}
