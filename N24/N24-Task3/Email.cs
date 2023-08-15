namespace N24_Task3;

public class Email
{
    public string receiverEmailAddress { get; set; }
    public string senderEmailAddress { get; set; }
    public string subject { get; set; }
    public string body { get; set; }    
    public DateTime date { get; set; }
    public bool isClassified { get; set; }

    public Email(string receiverEmailAddress, string senderEmailAddress, string subject, string body, DateTime date, bool isClassified)
    {
        this.receiverEmailAddress = receiverEmailAddress;
        this.senderEmailAddress = senderEmailAddress;
        this.subject = subject;
        this.body = body;
        this.date = date;
        this.isClassified = isClassified;
    }

    public override string ToString()
    {
        return $"{receiverEmailAddress} {senderEmailAddress} {subject} {body} {date} {isClassified}";
    }
}