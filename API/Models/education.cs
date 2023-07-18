namespace API.Models;

public class education
{
    public Guid Guid { get; set; }
    public String Major { get; set; }
    public String Degree { get; set; }
    public double GPA { get; set; }
  
    public DateTime CreateDate { get; set; }
    public DateTime ModifiedDate { get; set; }
    public Guid UniversityGuid { get; set; }
}
