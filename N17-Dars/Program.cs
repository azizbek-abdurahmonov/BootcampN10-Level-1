public class User
{
    public Guid ID { get; init; }
    public string shortName { get; set; }
    public string FullName { get; set; }
    public DateOnly DateOfBirth { get; set; }
    
}
