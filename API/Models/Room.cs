using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Models;
[Table("tb_m_rooms")]
public class Room : BaseEntity
{
    [Column("name", TypeName = "nvarchar(100)")]
    public String Name { get; set; }
    [Column("floor")]
    public int Floor { get; set; }
    [Column("capacity")]
    public int Capacity { get; set; }
    //cardibilities
    public ICollection<Booking>? Bookings { get; set; }

}
