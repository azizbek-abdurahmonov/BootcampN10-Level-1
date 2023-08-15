namespace N24_HT1.Models;

public class User
{
    public Guid Id { get; set; }
    public string firstName { get; set; }
    public string lastName { get; set; }
    public string emailAddress { get; set; }
    public bool isDeleted { get; set; }

    public User(string firstName, string lastName, string emailAddress, bool isDeleted = false)
    {
        Id = Guid.NewGuid();
        this.firstName = firstName;
        this.lastName = lastName;
        this.emailAddress = emailAddress;
        this.isDeleted = isDeleted;
    }
    
    public override string ToString()
    {
        return $"{firstName} {lastName} {emailAddress} {isDeleted}\n";
    }
}