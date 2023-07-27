using System.Globalization;
using System.Linq.Expressions;

var v1 = new BankAccount("Azizbek", "Abdurahmonov");
Console.WriteLine(v1);

var v2 = new BankAccount("Azizbek", "Abdurahmonov", 10);
Console.WriteLine(v2);

var s1 = new SecureBankAccount("Azizbek", "Abdurahmonov", 150);
Console.WriteLine(s1);

var s2 = new SecureBankAccount("Azizbek", "Abdurahmonov", 100, "AA091301391039");
Console.WriteLine(s2);


public class BankAccount
{
    public string firstName;
    public string lastName;
    public int deposit;

    public BankAccount(string firstName, string lastName, int deposit = 20)
    {
        this.firstName = firstName;
        this.lastName = lastName;
        this.deposit = deposit;

        if (!(deposit > 0))
            throw new Exception("Deposit 0 dan katta bo'lishi kerak!");
    }


    public override string ToString()
    {
        return $"first name: {firstName}\nlast name: {lastName}\ndeposit: {deposit}";
    }
}

public class SecureBankAccount : BankAccount
{
    public string passport;
    public SecureBankAccount(string firstName, string lastName, int deposit)
        :base(firstName, lastName, deposit)
    {
    }

    public SecureBankAccount(string firstName, string lastName, int deposit, string passport)
        :base(firstName, lastName, deposit)
    {
        this.passport = passport;
    }

    //public override string ToString()
    //{
    //    return $"first name: {firstName}\nlast name: {lastName}\ndeposit: {deposit}";
    //}
}