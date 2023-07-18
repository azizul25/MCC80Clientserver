using System.ComponentModel.DataAnnotations;

namespace API.Models;

public class Account : BaseEntity
{
    public String Password { get; set; }
    public int Otp { get; set; }
    public bool Isused { get; set; }
    public DateTime EcpiredTime { get; set; }

}
