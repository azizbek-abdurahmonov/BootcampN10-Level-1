Animal cat = new Cat();
Animal dog = new Dog();
Animal bear = new Bear();

cat.FunFact();
dog.FunFact();
bear.FunFact();

public class Animal
{
    public virtual void FunFact()
    {
        Console.WriteLine("...");
    }
}

public class Cat : Animal
{
    public override void FunFact()
    {
        Console.WriteLine("Mushuklar uzoq masofalarni qisqa vaqtda sayramoqqa qodir.");
    }
}

public class Dog : Animal
{
    public override void FunFact()
    {
        Console.WriteLine("Tasavvur qiling kuchuk haqida judayam qiziqarli fact yozilgan");
    }
}

public class Bear : Animal
{
    public override void FunFact()
    {
        Console.WriteLine("Tasavvur qiling ayiq haqida judayam qiziqarli fact yozilgan");
    }
}