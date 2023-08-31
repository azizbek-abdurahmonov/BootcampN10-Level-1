namespace N32_T2.Models;

public class ChatMessage : AuditableEntity
{
    public Guid Id { get; set; }
    public string Subject { get; set; }
    public string Message { get; set; }
    public Guid ChatId { get; set; }


    public ChatMessage(string subject, string message, Guid chatId)
    {
        Id = Guid.NewGuid();
        Subject = subject;
        Message = message;
        ChatId = chatId;
    }

    public override string ToString()
    {
        return $"{Subject} {Message} ";
    }

    public override int GetHashCode()
    {
        return Subject.GetHashCode() + Message.GetHashCode();
    }

    public override bool Equals(object? obj)
    {
        return obj.GetHashCode() == this.GetHashCode();
    }
}