namespace N32_T2.Models;

public abstract class AuditableEntity
{
    public DateTime CreatedDate { get; set; }
    public DateTime ModifiedDate { get; set; }
}