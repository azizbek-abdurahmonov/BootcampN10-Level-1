using System.Text.RegularExpressions;

var validator = new Validator();
Console.WriteLine(validator.IsValidName("Azizbek"));
Console.WriteLine(validator.IsValidName("Abdurahmonov"));
Console.WriteLine(validator.isValidEmailAddress("abdura52@gmail.com"));
Console.WriteLine(validator.IsValidPhoneNumber("+998970183595"));




public class Validator
{
    private Regex _fullNameRegex = new Regex("^[a-zA-Z'-]+$");
    private Regex _emailAddressRegex = new Regex("^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\\.[a-zA-Z]{2,}$");
    private Regex _phoneNumberRegex = new Regex("^\\+?\\d{1,3}?[-.\\s]?\\(?\\d{1,4}\\)?[-.\\s]?\\d{1,4}[-.\\s]?\\d{1,9}$");

    public bool IsValidName(string name)
    {
        return _fullNameRegex.IsMatch(name);
    }

    public bool isValidEmailAddress(string emailAddress)
    {
        return _emailAddressRegex.IsMatch(emailAddress);
    }

    public bool IsValidPhoneNumber(string phoneNumber)
    {
        return _phoneNumberRegex.IsMatch(phoneNumber);
    }

}