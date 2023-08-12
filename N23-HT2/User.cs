namespace N23_HT2;

public class User
{
    public string firstName { get; set; }
    public string lastName { get; set; }
    public string emailAddress { get; set; }

    public User(string firstName, string lastName, string emailAddress)
    {
        this.firstName = firstName;
        this.lastName = lastName;
        this.emailAddress = emailAddress;
    }
    
    public override string ToString()
    {
        return $"{firstName} {lastName} - {emailAddress}";
    }
}