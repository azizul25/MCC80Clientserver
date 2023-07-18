namespace API.Models;

public class Employee : BaseEntity
{
  
    public String Nik { get; set; }
    public String FirstName { get; set; }
    public String LastName { get; set; }
    public DateTime BirthDate { get; set; }
    public int Gender { get; set; }
    public DateTime HiringDate { get; set; }
    public String Email { get; set; }
    public String PhoneNumber { get; set; }
   
    
}
