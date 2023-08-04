using N19_HT1;

Validator.isValidName("   Azizbek ", out var formattedName);
Console.WriteLine(formattedName);

Validator.IsValidEmailAddress("   abdura@gmail.com       ", out var formattedEmailAddress);
Console.WriteLine(formattedEmailAddress);

Console.WriteLine(Validator.isValidAge(15));

Validator.IsValidPhoneNumber("  +998970110101   ", out var phonenumber);
Console.WriteLine(phonenumber);
