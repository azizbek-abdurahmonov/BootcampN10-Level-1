// 1 - usul
var user1 = new User();
user1.ism = "Azizbek";
user1.sharif = "Alisherovich";
user1.familiya = "Abdurahmonov";

Console.WriteLine($"1- user: {user1.FullName}");

var user2 = new User();
user2.ism = "Azizbek";
user2.sharif = "Alisherovich";
user2.familiya = "Abdurahmonov";

Console.WriteLine($"1- user: {user2.FullName}");

Console.WriteLine(user1.Equals(user2));



public class User
{
    public string ism { get; set; }
    public string sharif { get; set; }
    public string familiya { get; set; }
    public string FullName => $"{familiya} {ism} {sharif}";

    public override int GetHashCode()
    {
        return this.ism.GetHashCode() + this.sharif.GetHashCode() + this.familiya.GetHashCode();
    }

    public override bool Equals(object? obj)
    {
        if (obj is User user)
            return user.GetHashCode() == this.GetHashCode();

        return false;
    }
}


// 2 - usul

//var user1 = new User();
//try
//{
//    user1.FullName = "Abdurahmonov Azizbek Alisherovich";
//}
//catch (Exception ex)
//{
//    Console.WriteLine(ex.Message);
//}

//var user2 = new User();
//try
//{
//    user2.FullName = "Abdurahmonov Azizbek Alisherovich";

//}
//catch(Exception ex)
//{
//    Console.WriteLine(ex.Message);
//}

//Console.WriteLine(user1.Equals(user2)); // True - ularning qiymatlari bir xil


//public class User
//{
//    private string _name;
//    private string _firstName;
//    private string _lastName;
//    private string _fullName;


//    public string FullName
//    {
//        get
//        {
//            return _fullName;
//        }
//        set
//        {
//            if (string.IsNullOrWhiteSpace(value))
//                throw new Exception("Hech narsa kiritmadingiz!");

//            if (value.Split().Length != 3)
//                throw new Exception("Ism, Familiya va Sharif noto'g'ri formatda kiritildi!");

//            var names = value.Split();
//            _name = names[1];
//            _firstName = names[2];
//            _lastName = names[0];
//            _fullName = value;
//        }
//    }

//    public override int GetHashCode()
//    {
//        return this._name.GetHashCode() + this._firstName.GetHashCode() + this._lastName.GetHashCode();
//    }

//    public override bool Equals(object? obj)
//    {
//        if (obj is User user)
//        {
//            return user.GetHashCode() == this.GetHashCode();
//        }

//        return false;
//    }

//}