//var pass = new PasswordGenerate(10, true, true);
//try
//{
//    Console.WriteLine(pass.Generate());

//}
//catch (Exception ex)
//{
//    Console.WriteLine(ex.Message);
//}

//try
//{
//    var securepass = new SecurePasswordGenerator(0, true);
//    Console.WriteLine(securepass.Generate(true));
//}
//catch (Exception ex)
//{
//    Console.WriteLine(ex.Message);
//}

try
{
    var unique = new UniquePasswordGenerate(10, true, true);
    Console.WriteLine(unique.GenerateUniqePassword());
}
catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}

public class PasswordGenerate
{
    public int _length;
    public bool _hasLetters;
    public bool _hasDigits;
    public string letters = "abcdefghikjlmnopqrstuvwxyz";
    public string digits = "1234567890";
    public string characters;



    public PasswordGenerate(int length, bool hasLetters, bool hasDigits = false)
    {
        _length = length;
        _hasLetters = hasLetters;
        _hasDigits = hasDigits;
    }

    public string Generate()
    {
        if (_length < 4)
            throw new Exception("password uzunligi kamida 4 belgidan iborat bo'lishi kerak");
        if (_hasLetters == false && _hasDigits == false)
            throw new Exception("Hech qanday belgilar tanlanmadi!");



        if (_hasLetters)
            characters += letters;
        if (_hasDigits)
            characters += digits;

        string password = default(string);

        var rd = new Random();
        for (var i = 0; i < _length; i++)
        {
            password += characters[rd.Next(0, characters.Length - 1)];
        }

        return password;

    }
}

//SecurePasswordGenerator

public class SecurePasswordGenerator : PasswordGenerate
{
    public SecurePasswordGenerator(int length, bool hasLetter, bool hasDigits = false)
        : base(length, hasLetter, hasDigits)
    {

    }

    public string symbols = "~!@#$%^&*()";

    public string Generate(bool hasSymbols)
    {
        if (_length < 4)
            throw new Exception("password uzunligi kamida 4 belgidan iborat bo'lishi kerak");
        if (_hasLetters == false && _hasDigits == false)
            throw new Exception("Hech qanday belgilar tanlanmadi!");

        if (hasSymbols)
            characters += symbols;
        if (_hasDigits)
            characters += digits;
        if (_hasLetters)
            characters += letters;

        string password = default(string);
        var rd = new Random();

        for (var i = 0; i < _length; i++)
        {
            password += characters[rd.Next(0, characters.Length - 1)];
        }

        return password;
    }
}

public class UniquePasswordGenerate : SecurePasswordGenerator
{
    public List<string> passwords = new List<string>();

    public UniquePasswordGenerate(int length, bool hasLetter, bool hasDigits = false) : base(length, hasLetter, hasDigits)
    {
    }

    public string GenerateUniqePassword()
    {
        while (true)
        {
            var pass = Generate();
            if (!(passwords.Contains(pass)))
            {
                passwords.Add(pass);
                return pass;
            }
        }
    }
}