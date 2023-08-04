public class BankAccount
{
    protected string accountHolderName;
    protected int accountNumber;
    protected double Balance;


    public virtual bool Deposit(int amount)
    {
        if (amount > 1000)
        {
            Balance += amount;
            return true;
        }
        else
        {
            return false;
        }
    }


}