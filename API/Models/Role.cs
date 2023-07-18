namespace API.Models;

public class Role
{
    public Guid Guid { get; set; }
    public String Name { get; set; }
    public DateTime CreateDate { get; set; }
    public DateTime ModifiedDate { get; set; }
}
