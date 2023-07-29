using System.Diagnostics.Contracts;
var messager = new NotificationMessages();
Console.WriteLine(messager.SearchMessage("pass")); // shu nomdagi message consolega chiqadi
Console.WriteLine(messager.SearchMessage("Jumanazar haqida message")); // message mavjud emas , shuning uchun message topilmadi teksti consolega chiqadi


public class NotificationMessages
{
    private Dictionary<string, string> Messages = new Dictionary<string, string>();

    public NotificationMessages()
    {
        Messages.Add("SuccRegistration", "You successfully registered");
        Messages.Add("AskPassword", "Enter your password");
        Messages.Add("Blocked", "Your account has been blocked");
    }
    protected KeyValuePair<string, string> FindMessage(string messageName)
    {
        foreach (var message in Messages)
        {
            if (message.Key.ToLower().Contains(messageName.ToLower()))
                return message;
        }
        var notFound = new KeyValuePair<string, string>("NotFound", "Message topilmadi");
        return notFound;
    }

    public string SearchMessage(string messageName)
    {
        return FindMessage(messageName).Value.ToString();
    }
}