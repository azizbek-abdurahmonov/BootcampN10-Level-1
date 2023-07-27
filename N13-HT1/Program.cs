var sparrow = new Sparrow();
var tiger = new Tiger();
var shark = new GreatWhiteShark();

sparrow.Fly();
tiger.Run();
shark.Swim();


public class Animal
{
    public void MakeSound()
    {
        Console.WriteLine("...");
    }
}

public class Bird : Animal
{
    public void Fly()
    {
        Console.WriteLine("Fly");
    }
}

public class Mammal : Animal
{
    public void Run()
    {
        Console.WriteLine("Run");
    }
}

public class Fish : Animal
{
    public void Swim()
    {
        Console.WriteLine("Swim");
    }
}

public class Sparrow : Bird
{

}

public class Tiger : Mammal
{

}

public class GreatWhiteShark : Fish
{

}

