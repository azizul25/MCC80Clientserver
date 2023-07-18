namespace API.Models;

public class Room : BaseEntity
{

    public String Name { get; set; }
    public int floor { get; set; }
    public int capacity { get; set; }

}
