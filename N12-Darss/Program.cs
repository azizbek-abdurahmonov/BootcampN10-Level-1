var n1 = new Animal();
//while (true)
//{
//    try
//    {
//        Console.WriteLine("Enter your animal's name: ");
//        n1.Name = Console.ReadLine();
//        Console.WriteLine("Done");
//        break;
//    }
//    catch(Exception ex)
//    {
//        Console.WriteLine(ex.Message);
//    }
    
//}

public class User
{
    public string Name;
    public int Age;

    
    public int AGE
    {
        get
        {
            return Age;
        }
        set
        {
            if (value is >= 18 and <= 90)
                Age = value;
            else
                throw new Exception("Yosh chegarasidan o'tib ketdi!");
        }

    }
}

public class Animal
{
    public string Name
    {
        get
        {
            return Name;
        }
        set
        {
            if (value.Length > 4)
                Name = value;
            else
                throw new Exception("Hayvonlar ismi kamida 4 harfdan iborat bo'lishi kerak");
        }
    }

}