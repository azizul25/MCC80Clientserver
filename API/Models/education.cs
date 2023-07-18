using System.ComponentModel.DataAnnotations.Schema;

namespace API.Models;
[Table("tb_m_educations")]
public class Education : BaseEntity
{
    [Column("major",TypeName = "nvarchar(100)")]
    public String Major { get; set; }
    [Column("degree", TypeName = "nvarchar(100)")]
    public String Degree { get; set; }
    [Column("gpa")]
    public double GPA { get; set; }

    [Column("universiyguid")]
    public Guid UniversityGuid { get; set; }
}
