var game = new OptimizedGameEngine();
game.Display();


public class Hero
{
    public Guid Id { get; set; }
    public string Name { get; set; }

    public Hero(string name)
    {
        Name = name;
        Id = Guid.NewGuid();
    }

    public override string ToString()
    {
        return $"Name: {Name}\nId: {Id}\n";
    }

}

public class GameEngine
{
    public List<Hero> HeroList = new List<Hero>();

    public void Display()
    {
        foreach (var hero in HeroList)
        {
            Console.WriteLine(hero);
        }
    }

    public GameEngine()
    {
        HeroList.Add(new Hero("Invoker"));
        HeroList.Add(new Hero("Sven"));
        HeroList.Add(new Hero("Tiny"));
    }
}

public class OptimizedGameEngine : GameEngine
{
    public OptimizedGameEngine()
    {
        HeroList.Add(new Hero("Lina"));
        HeroList.Add(new Hero("Meduse"));
        HeroList.Add(new Hero("Yurnero"));
    }
}

