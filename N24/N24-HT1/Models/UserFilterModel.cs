namespace N24_HT1.Models;

public class UserFilterModel : FilterModel
{
    public string? firstName { get; set; }
    public string? lastName { get; set; }
    public int pageSize { get; set; }
    public int pageToken { get; set; }


    public UserFilterModel(string? firstName, string? lastName, int pageSize, int pageToken)
    {
        this.firstName = firstName;
        this.lastName = lastName;
        this.pageSize = pageSize;
        this.pageToken = pageToken;
    }
}