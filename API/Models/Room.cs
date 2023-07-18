namespace API.Models;

public class rooms
{
    public Guid Guid { get; set; }
    public String Name { get; set; }
    public int floor { get; set; }
    public int capacity { get; set; }
    public DateTime CreateDate { get; set; }
    public DateTime ModifiedDate { get; set; }
}
