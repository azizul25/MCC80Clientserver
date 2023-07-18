namespace API.Models;

public class University
{
    public Guid Guid { get; set; }
    public String Code { get; set; }
    public String Name { get; set; }
    public DateTime CreateDate { get; set; }
    public DateTime ModifiedDate { get; set; }
}
