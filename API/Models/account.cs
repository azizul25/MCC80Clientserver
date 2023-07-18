namespace API.Models;

public class account
{
    public Guid Guid { get; set; }
    public String Password { get; set; }
    public int Otp { get; set; }
    public bool isused { get; set; }
    public DateTime EcpiredTime { get; set; }
    public DateTime CreateDate { get; set; }
    public DateTime ModifiedDate { get; set; }
}
