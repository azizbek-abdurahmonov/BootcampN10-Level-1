namespace N24_HT1.Models;

public class UserCredentials
{
    public Guid Id { get; set; }
    public string password { get; set; }
    public Guid userId { get; set; }

    public UserCredentials(string password, Guid userId)
    {
        Id = Guid.NewGuid();
        this.password = password;
        this.userId = userId;
    }
}