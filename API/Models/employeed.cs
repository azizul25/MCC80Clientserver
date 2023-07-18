namespace API.Models;

public class employeed
{
    public Guid Guid { get; set; }
    public String Nik { get; set; }
    public String FirstName { get; set; }
    public String LastName { get; set; }
    public DateTime BirthDate { get; set; }
    public int Gender { get; set; }
    public DateTime HiringDate { get; set; }
    public String Email { get; set; }
    public String Phonenumber { get; set; }
    public DateTime CreateDate { get; set; }
    public DateTime ModifiedDate { get; set; }
    
}
