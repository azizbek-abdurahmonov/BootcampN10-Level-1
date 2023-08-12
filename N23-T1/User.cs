namespace N23_T1;

public class User
{
    public string EmailAddress { get; set; }
    public string Password { get; set; }
    public bool IsEmailVerified { get; set; }
    public bool IsPhoneVerified { get; set; }

    public User(string emailAddress, string password, bool isEmailVerified = false, bool isPhoneVerified = false)
    {
        EmailAddress = emailAddress;
        Password = password;
        IsEmailVerified = isEmailVerified;
        IsPhoneVerified = isPhoneVerified;
    }
}