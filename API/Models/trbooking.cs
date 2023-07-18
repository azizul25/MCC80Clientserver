namespace API.Models;

public class trbooking
{
    public Guid Guid { get; set; }
    public DateTime StarDate { get; set; }
    public DateTime EndDate { get; set; }

    public int status { get; set; }
    public String remarks { get; set; }
    public int capacity { get; set; }
    public DateTime CreateDate { get; set; }
    public DateTime ModifiedDate { get; set; }
    public Guid RoomGuid { get; set; }
    public Guid EmployedGuid { get; set; }

}
