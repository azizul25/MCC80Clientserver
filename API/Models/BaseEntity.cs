using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Models;

public abstract class BaseEntity
{
    [Key]
    [Column("guid")]
    public Guid Guid { get; set; }
    [Column("createddate")]
    public DateTime CreatedDate { get; set; }
    [Column("modifieddate")]
    public DateTime ModifiedDate { get; set; }
}
