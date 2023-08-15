using System.Runtime.InteropServices.ComTypes;

namespace N24_Task3;

public class EmailService
{
    public List<Email> GetBySender(List<Email> emails, string sender, int pageSize, int pageToken)
    {
        return emails.Where(email => email.senderEmailAddress == sender).OrderByDescending(e => e.date)
            .Skip((pageToken - 1) * pageSize).Take(pageSize).ToList();
    }

    public List<Email> GetByReceive(List<Email> emails, string receiver, int pageSize, int pageToken)
    {
        return emails.Where(email => email.receiverEmailAddress == receiver).OrderByDescending(e => e.date)
            .Skip((pageToken - 1) * pageSize).Take(pageSize).ToList();
    }

    public List<Email> Get(List<Email> emails, EmailFilterModel filter)
    {
        return filter.senderEmailAddress is null
               && filter.receiverEmailAddress is null
               && filter.date is null
            ? emails
            : emails.Where(e =>
                    !e.isClassified
                    && (filter.senderEmailAddress is null || filter.senderEmailAddress == e.senderEmailAddress)
                    && (filter.receiverEmailAddress is null || filter.receiverEmailAddress == e.receiverEmailAddress)
                    && (filter.date is null || filter.date == e.date))
                .Skip((filter.pageToken - 1) * filter.pageSize)
                .Take(filter.pageSize).ToList();
    }
}