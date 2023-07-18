namespace API.Models;

public class Education : BaseEntity
{
    public String Major { get; set; }
    public String Degree { get; set; }
    public double GPA { get; set; }
  

    public Guid UniversityGuid { get; set; }
}
