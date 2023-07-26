var user1 = new User();
try
{
    user1.FullName = "Abdurahmonov Azizbek Alisherovich";
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

var user2 = new User();
try
{
    user2.FullName = "Abdurahmonov Azizbek Alisherovich";

}
catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}

Console.WriteLine(user1.Equals(user2)); // True - ularning qiymatlari bir xil


public class User
{
    private string _name;
    private string _firstName;
    private string _lastName;
    private string _fullName;


    public string FullName
    {
        get
        {
            return _fullName;
        }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new Exception("Hech narsa kiritmadingiz!");

            if (value.Split().Length != 3)
                throw new Exception("Ism, Familiya va Sharif noto'g'ri formatda kiritildi!");

            var names = value.Split();
            _name = names[1];
            _firstName = names[2];
            _lastName = names[0];
            _fullName = value;
        }
    }

    public override int GetHashCode()
    {
        return this._name.GetHashCode() + this._firstName.GetHashCode() + this._lastName.GetHashCode();
    }

    public override bool Equals(object? obj)
    {
        if (obj is User user)
        {
            return user.GetHashCode() == this.GetHashCode();
        }

        return false;
    }

}