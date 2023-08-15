namespace N24_Task3;

public class EmailFilterModel
{
    public string? receiverEmailAddress { get; set; }
    public string? senderEmailAddress { get; set; }
    public DateTime? date { get; set; }
    public int pageSize { get; set; }
    public int pageToken { get; set; }

    public EmailFilterModel(string? receiverEmailAddress, string? senderEmailAddress, DateTime? date, int pageSize, int pageToken)
    {
        this.receiverEmailAddress = receiverEmailAddress;
        this.senderEmailAddress = senderEmailAddress;
        this.date = date;
        this.pageSize = pageSize;
        this.pageToken = pageToken;
    }
}