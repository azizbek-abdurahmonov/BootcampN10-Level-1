using System.Globalization;
using System.Net;

var inventory = new Inventory<IItem>();
inventory.Add(new Weapon("AK-47", "ak.png", 250));
inventory.Add(new Money("emerald", "emerald.png", 1500));
inventory.Add(new Weapon("Scout", "scout.png", 1000));
inventory.Add(new Weapon("M416", "mk.png", 500));
inventory.Add(new Money("emerald", "emerald.png", 1500));
inventory.Add(new Money("emerald", "emerald.png", 1500));

foreach(var weapon in inventory.GetWeapons())
    Console.WriteLine($"{weapon.name} - {weapon.image}");

public class Inventory<TItem> where TItem : IItem
{
    private List<TItem> _items = new();

    public void Add(TItem item)
    {
        _items.Add(item);
    }

    public List<Weapon> GetWeapons()
    {
        return _items.OfType<Weapon>().ToList();
    }


}

public interface IItem
{
    string name { get; set; }
    string image { get; set; }

}

public class Weapon : IItem
{
    public string name { set; get; }
    public string image { set; get; }
    public int damage { set; get; }

    public Weapon(string name, string image, int damage)
    {
        this.name = name;
        this.image = image;
        this.damage = damage;
    }
}

public class Money : IItem
{
    public string name { get; set; }
    public string image { set; get; }
    public int money { set; get; }

    public Money(string name, string image, int money)
    {
        this.name = name;
        this.image = image;
        this.money = money;
    }
}