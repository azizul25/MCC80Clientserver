﻿namespace API.Models;

public class Accountrole
{
    public Guid Guid { get; set; }
    public DateTime CreateDate { get; set; }
    public DateTime ModifiedDate { get; set; }
    public Guid AccountGuid { get; set; }
    public Guid RoleGuid { get; set; }
}
